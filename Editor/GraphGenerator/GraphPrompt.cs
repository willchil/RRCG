using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RRCG;
using RRCGSource;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using UnityEditor;
using UnityEditor.Compilation;
using UnityEngine;
using File = System.IO.File;

public class PromptWindow : EditorWindow
{
    private const string OLLAMA_HOST = "localhost";
    private const int OLLAMA_IP = 11434;

    private string userPrompt = "Log the first 10 fibonacci numbers.";
    private static bool generating = false;
    private static string[] modelNames = new string[0];
    private int selectedModelIndex = 0;
    private static int seed = 0;
    private CancellationTokenSource cancellationTokenSource = null;

    private string ModelName => modelNames[selectedModelIndex];

    internal static string GeneratedFile = string.Empty;
    internal const string GENERATED_PATH = "Assets/Generated";

    void OnGUI()
    {
        EditorGUILayout.HelpBox("Enter a prompt to describe your intended circuit graph.", MessageType.Info);
        GUI.enabled = !generating;

        userPrompt = EditorGUILayout.TextField("Prompt", userPrompt);

        // Display dropdown of installed Ollama models
        selectedModelIndex = EditorGUILayout.Popup("Model", selectedModelIndex, modelNames);
        GUI.enabled = true;

        if (generating)
        {
            if (GUILayout.Button("Stop") ||
                (Event.current.type == EventType.KeyDown && Event.current.keyCode == KeyCode.Return))
            {
                generating = false;
                cancellationTokenSource.Cancel();
            }
        }
        else
        {
            if (GUILayout.Button("Generate") ||
                (Event.current.type == EventType.KeyDown && Event.current.keyCode == KeyCode.Return))
            {
                if (!string.IsNullOrWhiteSpace(userPrompt))
                {
                    generating = true;
                    seed = 0;
                    async Task submit()
                    {
                        cancellationTokenSource = new CancellationTokenSource();
                        var (script, className) = await SubmitPrompt(userPrompt, cancellationTokenSource.Token);
                        if (cancellationTokenSource.Token.IsCancellationRequested) return;
                        var filename = className + ".rrcg.cs";
                        SaveSourceFile(script, filename);
                        GeneratedFile = $"{GENERATED_PATH}/{filename}";
                    }
                    _ = submit();
                }
            }
        }
    }

    private async void OnEnable()
    {
        // Fetch models on window enable
        modelNames = await FetchOllamaModels();
        Repaint();
    }

    private async Task<(string script, string name)> SubmitPrompt(string task, CancellationToken cancellationToken)
    {
        Debug.Log($"Processing prompt:\n{task}");
        var className = "GenScript_" + Regex.Replace(Guid.NewGuid().ToString(), "[^a-zA-Z0-9]", "");
        var valid = false;
        var script = string.Empty;
        do
        {
            var response = await SendPromptToOllama(task, cancellationToken);
            var code = ExtractCSharpCodeBlock(response);
            script = FormatScript(code, className);
            var empty = string.IsNullOrEmpty(response);
            var compiles = CodeValidator.IsCodeCompilable(script, out var errors);
            if (!compiles)
            {
                var msg = empty ? "No code found." : $"{script}\n\n{string.Join("\n", errors)}";
                Debug.LogWarning($"Invalid script, regenerating...\n\n{msg}");
            }
            valid = !empty && compiles;
            seed++;
        } while (!valid && generating);
        if (cancellationToken.IsCancellationRequested) script = string.Empty;
        generating = false;
        return (script, className);
    }

    /// <summary>
    /// Generates a system prompt with the necessary context.
    /// </summary>
    /// <returns>
    /// Returns the system prompt.
    /// </returns>
    private static string GetSystemMessage()
    {
        var promptPath = Path.Combine(GenerateChipsInterface.EditorDirectory, "GraphGenerator", "PromptTemplate.txt");
        var promptTemplate = File.ReadAllText(promptPath);
        const string INTERFACE_TAG = "[CHIPS]";

        var interfaceText = GenerateChipsInterface.GetInterfaceText();
        return promptTemplate.Replace(INTERFACE_TAG, interfaceText);
    }

    private async Task<string> SendPromptToOllama(string prompt, CancellationToken cancellationToken)
    {
        try
        {
            using (var client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(86400);

                // Construct the request payload as a JSON object
                var payload = new
                {
                    model = ModelName,
                    system = GetSystemMessage(),
                    prompt = prompt,
                    stream = false,
                    options = new
                    {
                        num_ctx = 21000,
                        seed = seed
                    }
                };

                // Serialize the payload to JSON
                var json = JsonConvert.SerializeObject(payload);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Send the POST request
                var response = await client.PostAsync($"http://{OLLAMA_HOST}:{OLLAMA_IP}/api/generate", content, cancellationToken);

                response.EnsureSuccessStatusCode(); // Throw if the response is not successful

                // Read the response content
                var responseString = await response.Content.ReadAsStringAsync();

                // Parse the JSON response
                var responseObject = JObject.Parse(responseString);

                // Extract the "response" field
                if (responseObject.TryGetValue("response", out var responseToken))
                {
                    string ollamaResponse = responseToken.ToString();

                    // Replace escape sequences for a cleaner result
                    ollamaResponse = ollamaResponse
                        .Replace("\\n", "\n")
                        .Replace("\\\"", "\"")
                        .Trim();

                    return ollamaResponse;
                }
                else
                {
                    // Handle cases where the "response" field is missing
                    EditorUtility.DisplayDialog("Error", "Could not parse response", "Close");
                    Debug.LogError(responseString);
                    return string.Empty;
                }
            }
        }
        catch (OperationCanceledException)
        {
            return string.Empty;
        }
        catch (Exception ex)
        {
            // Log and display error information
            EditorUtility.DisplayDialog("Error", $"An error occurred: {ex.Message}", "Close");
            return string.Empty;
        }
    }

    private async Task<string[]> FetchOllamaModels()
    {
        try
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"http://{OLLAMA_HOST}:{OLLAMA_IP}/api/tags");
                response.EnsureSuccessStatusCode();

                // Parse response
                var responseString = await response.Content.ReadAsStringAsync();
                var responseObject = JObject.Parse(responseString);
                var models = responseObject["models"].Select(model => model["name"].ToString());
                return models.ToArray();
            }
        }
        catch (HttpRequestException ex)
        {
            Debug.LogError($"Error fetching models: {ex.Message}");
        }

        return new string[0];
    }

    private static string ExtractCSharpCodeBlock(string input)
    {
        // Define the regex pattern to match the C# code block
        string pattern = @"```(?:cs|csharp)\s(.*?)```";

        // Use RegexOptions.Singleline to allow '.' to match newlines
        var regex = new Regex(pattern, RegexOptions.Singleline);

        // Find all matches in the input string
        var matches = regex.Matches(input);

        if (matches.Count == 0)
        {
            // Return an empty string if no code blocks are found
            return string.Empty;
        }

        // Iterate through the matches and return the one with the most characters
        var longestMatch = matches.Cast<Match>()
                                  .OrderByDescending(match => match.Groups[1].Value.Length)
                                  .LastOrDefault();

        // Return the longest code block, trimming leading/trailing spaces
        return longestMatch?.Groups[1].Value.Trim() ?? string.Empty;
    }

    private static string FormatScript(string circuitGraph, string className)
    {
        var templatePath = Path.Combine(GenerateChipsInterface.EditorDirectory, "GraphGenerator", "ScriptTemplate.txt");
        var scriptTemplate = File.ReadAllText(templatePath);
        const string CLASS_TAG = "[CLASS]";
        const string SCRIPT_TAG = "[SCRIPT]";

        var lines = circuitGraph.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
        var formattedLines = lines.Select((line, index) => index == 0 ? line : "    " + line).ToArray();
        circuitGraph = string.Join(Environment.NewLine, formattedLines);

        return scriptTemplate.Replace(CLASS_TAG, className).Replace(SCRIPT_TAG, circuitGraph);
    }

    private static string SaveSourceFile(string content, string filename)
    {
        // Get the absolute path to the Assets folder
        string assetsPath = Application.dataPath;

        // Combine to get the path for the Generated folder inside Assets
        string generatedFolderPath = Path.Combine(assetsPath, "Generated");

        // Create the folder if it doesn't exist
        if (!Directory.Exists(generatedFolderPath))
        {
            Directory.CreateDirectory(generatedFolderPath);
        }

        // Combine the folder path with the filename to get the full file path
        string filePath = Path.Combine(generatedFolderPath, filename);

        // Write the content to the file
        File.WriteAllText(filePath, content);



        // Refresh the Asset Database so the new file shows up in the Unity Editor immediately.
        AssetDatabase.ImportAsset(filePath);

        return filePath;
    }
}