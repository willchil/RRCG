using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RRCGSource;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using File = System.IO.File;

public class PromptWindow : EditorWindow
{
    private const string MODEL_NAME = "qwen2.5-coder:32b";

    private string userPrompt = "";
    private bool generating = false;

    void OnGUI()
    {
        EditorGUILayout.HelpBox("Enter a prompt to describe your intended circuit graph.", MessageType.Info);

        userPrompt = EditorGUILayout.TextField("Prompt:", userPrompt);

        GUI.enabled = !generating;
        if (GUILayout.Button("Generate") ||
            (Event.current.type == EventType.KeyDown && Event.current.keyCode == KeyCode.Return))
        {
            if (!string.IsNullOrWhiteSpace(userPrompt))
            {
                generating = true;
                _ = SubmitPrompt(userPrompt);
                GUI.FocusControl(null);
            }
        }
        GUI.enabled = true;
    }

    private async Task SubmitPrompt(string prompt)
    {
        prompt = GetFormattedPrompt(prompt);
        Debug.Log(prompt);
        var response = await SendPromptToOllama(prompt);
        var code = ExtractCSharpCodeBlock(response);
        Debug.Log(string.IsNullOrEmpty(code) ? $"No code found:\n{response}" : FormatScript(code));
        generating = false;
    }

    /// <summary>
    /// Formats a prompt with the necessary context.
    /// </summary>
    /// <param name="prompt">
    /// The prompt input by the user.
    /// </param>
    /// <returns>
    /// Returns the formatted prompt.
    /// </returns>
    private static string GetFormattedPrompt(string prompt)
    {
        var promptPath = Path.Combine(GenerateChipsInterface.RuntimeDirectory, "GraphGenerator", "PromptTemplate.txt");
        var promptTemplate = File.ReadAllText(promptPath);
        const string INTERFACE_TAG = "[CHIPS]";
        const string PROMPT_TAG = "[PROMPT]";

        var interfaceText = GenerateChipsInterface.GetInterfaceText();
        return promptTemplate.Replace(PROMPT_TAG, prompt.Trim()).Replace(INTERFACE_TAG, interfaceText);
    }

    private async Task<string> SendPromptToOllama(string prompt)
    {
        try
        {
            using (var client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(60000);

                // Construct the request payload as a JSON object
                var payload = new
                {
                    model = MODEL_NAME,
                    prompt = prompt,
                    stream = false
                };

                // Serialize the payload to JSON
                string json = JsonConvert.SerializeObject(payload);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Send the POST request
                var response = await client.PostAsync("http://localhost:11434/api/generate", content);

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
        catch (Exception ex)
        {
            // Log and display error information
            EditorUtility.DisplayDialog("Error", $"An error occurred: {ex.Message}", "Close");
            return string.Empty;
        }
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
                                  .FirstOrDefault();

        // Return the longest code block, trimming leading/trailing spaces
        return longestMatch?.Groups[1].Value.Trim() ?? string.Empty;
    }

    private static string FormatScript(string circuitGraph)
    {
        var templatePath = Path.Combine(GenerateChipsInterface.RuntimeDirectory, "GraphGenerator", "ScriptTemplate.txt");
        var scriptTemplate = File.ReadAllText(templatePath);
        const string CLASS_TAG = "[CLASS]";
        const string SCRIPT_TAG = "[SCRIPT]";

        var className = Regex.Replace(Guid.NewGuid().ToString(), "[^a-zA-Z0-9]", "");

        var lines = circuitGraph.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
        var formattedLines = lines.Select((line, index) => index == 0 ? line : "    " + line).ToArray();
        circuitGraph = string.Join(Environment.NewLine, formattedLines);

        return scriptTemplate.Replace(CLASS_TAG, className).Replace(SCRIPT_TAG, circuitGraph);
    }
}