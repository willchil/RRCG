using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Debug = UnityEngine.Debug;

namespace RRCGSource
{
    public class GenerateChipsInterface
    {
        public static void Generate()
        {
            string assetDirectory = Directory.GetCurrentDirectory();
            string scriptDirectory = Path.Combine(assetDirectory, "Packages", "RRCG", "Runtime", "Chips");

            string inputFilePath = Path.Combine(scriptDirectory, "Generated", "ChipsGen.cs");
            string outputFilePath = Path.Combine(scriptDirectory, "IChips.cs");

            if (!File.Exists(inputFilePath))
            {
                Debug.Log($"Input file {inputFilePath} does not exist.");
                return;
            }

            try
            {
                // Read the input file
                string[] lines = File.ReadAllLines(inputFilePath);

                // StringBuilder for constructing the output
                StringBuilder output = new StringBuilder();

                // Add comment block start
                output.AppendLine("/*");
                output.AppendLine("using System.Collections.Generic;");
                output.AppendLine("using UnityEngine;");
                output.AppendLine();
                output.AppendLine("namespace RRCGGenerated");
                output.AppendLine("{");
                output.AppendLine("    public interface IChips");
                output.AppendLine("    {");

                // Parse input file for comments and method signatures
                bool inComment = false;
                StringBuilder currentComment = new StringBuilder();
                bool hasComment = false;

                foreach (string line in lines)
                {
                    string trimmedLine = line.Trim();

                    // Detect and skip <summary> tags
                    if (trimmedLine.StartsWith("/// <summary>") || trimmedLine.StartsWith("/// </summary>"))
                    {
                        continue;
                    }

                    // Detect comment blocks
                    if (trimmedLine.StartsWith("///"))
                    {
                        inComment = true;
                        currentComment.AppendLine(DecodeSpecialCharacters(trimmedLine.Replace("///", "").Trim()));
                        hasComment = true;
                    }
                    else if (inComment && !trimmedLine.StartsWith("///"))
                    {
                        inComment = false;

                        // Write comment to the output
                        if (currentComment.Length > 0)
                        {
                            output.AppendLine(); // Blank line before the comment block
                            foreach (string commentLine in currentComment.ToString().Trim().Split('\n'))
                            {
                                output.AppendLine($"        // {commentLine.Trim()}");
                            }
                            currentComment.Clear();
                        }
                    }

                    // Detect method signatures, including tuple return types
                    if (trimmedLine.StartsWith("public") || trimmedLine.StartsWith("internal"))
                    {
                        // Use a regular expression to extract the return type and method signature
                        var match = Regex.Match(trimmedLine, @"(public|internal)\s+(static\s+)?(\(([^)]+)\)|\w+)\s+(\w+)\(([^)]*)\)");
                        if (match.Success)
                        {
                            string returnType = match.Groups[3].Value; // Handles tuple or regular return type
                            string methodName = match.Groups[5].Value;
                            string parameters = match.Groups[6].Value;

                            // Skip deprecated methods
                            if (methodName.IndexOf("deprecated", StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                hasComment = false; // Reset for the next method
                                continue;
                            }

                            // Add a blank line before the method if it has a comment
                            if (!hasComment)
                            {
                                output.AppendLine();
                                // Generate a default comment based on the method name
                                output.AppendLine($"        // {ConvertPascalCaseToWords(methodName)}");
                            }

                            output.AppendLine($"        {returnType} {methodName}({parameters});");
                            hasComment = false; // Reset for the next method
                        }
                    }
                }

                // Close interface and namespace
                output.AppendLine("    }");
                output.AppendLine("}");

                // Add comment block end
                output.AppendLine("*/");

                // Write to output file
                File.WriteAllText(outputFilePath, output.ToString());

                Debug.Log($"Interface successfully generated at {outputFilePath}");
            }
            catch (Exception ex)
            {
                Debug.Log($"An error occurred: {ex.Message}");
            }
        }

        // Helper function to decode special characters
        private static string DecodeSpecialCharacters(string input)
        {
            return input
                .Replace("&quot;", "\"")
                .Replace("&apos;", "'")
                .Replace("&amp;", "&")
                .Replace("&lt;", "<")
                .Replace("&gt;", ">");
        }

        // Helper function to convert PascalCase to words and capitalize first letter
        private static string ConvertPascalCaseToWords(string input)
        {
            string words = Regex.Replace(input, "(?<!^)([A-Z])", " $1").ToLowerInvariant();
            return char.ToUpper(words[0]) + words.Substring(1);
        }
    }
}
