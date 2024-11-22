using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Debug = UnityEngine.Debug;

namespace RRCGSource
{
    public static class GenerateChipsInterface
    {
        public static string RuntimeDirectory
        {
            get
            {
                var assetDirectory = Directory.GetCurrentDirectory();
                return Path.Combine(assetDirectory, "Packages", "RRCG", "Runtime");
            }
        }

        private static string ChipsPath => Path.Combine(RuntimeDirectory, "Chips", "Generated", "ChipsGen.cs");
        private static string InterfacePath => Path.Combine(RuntimeDirectory, "GraphGenerator", "IChips.txt");

        public static string GetInterfaceText()
        {
            if (!File.Exists(InterfacePath))  Generate();
            return File.ReadAllText(InterfacePath);

        }

        private static void Generate()
        {
            var inputFilePath = ChipsPath;
            var outputFilePath = InterfacePath;

            if (!File.Exists(inputFilePath))
            {
                Debug.Log($"Input file {inputFilePath} does not exist.");
                return;
            }

            try
            {
                string interfaceContent = ConvertToInterfaceDeclaration(inputFilePath, outputFilePath);
                Debug.Log($"Successfully generated interface at {outputFilePath}");
            }
            catch (Exception ex)
            {
                Debug.LogError($"Error generating interface: {ex.Message}");
            }
        }

        /// <summary>
        /// Converts a C# class file to an interface declaration
        /// </summary>
        private static string ConvertToInterfaceDeclaration(string inputFile, string outputFile)
        {
            // Read the entire input file
            string fileContent = File.ReadAllText(inputFile);

            // Extract namespace 
            var namespaceMatch = Regex.Match(fileContent, @"namespace\s+(\w+)");
            string namespaceName = namespaceMatch.Groups[1].Value;

            // Extract class name
            var classMatch = Regex.Match(fileContent, @"public\s+class\s+(\w+)");
            string className = classMatch.Groups[1].Value;

            // Find method declarations with their comments, excluding deprecated and internal methods
            var methodMatches = Regex.Matches(fileContent,
                @"(?:\/\/\/\s*<summary>\s*(?<comment>.*?)\s*<\/summary>)?\s*(public)\s+static\s+(?!.*(?i)deprecated)(?<returnType>\w+)\s+(?<methodName>\w+)\s*\((?<parameters>.*?)\)")
                .Cast<Match>()
                .Where(m => !Regex.IsMatch(m.Groups["methodName"].Value, @"(?i)deprecated"))
                .ToList();

            // Group methods by name
            var methodGroups = methodMatches
                .GroupBy(m => m.Groups["methodName"].Value);

            // Build interface declaration
            var interfaceBuilder = new StringBuilder();

            // Add using statements and namespace
            interfaceBuilder.AppendLine(Regex.Match(fileContent, @"((?:using\s+.*;\s*)+)").Value);

            interfaceBuilder.AppendLine($"namespace {namespaceName}");
            interfaceBuilder.AppendLine("{");
            interfaceBuilder.AppendLine($"    public interface I{className}");
            interfaceBuilder.AppendLine("    {");

            // Process each method group
            foreach (var methodGroup in methodGroups)
            {
                // Use the comment from the first method in the group
                var firstMethod = methodGroup.First();
                string comment = firstMethod.Groups["comment"].Success
                    ? firstMethod.Groups["comment"].Value.Trim()
                    : ConvertMethodNameToComment(methodGroup.Key);

                // Add comment only for the first method in the group
                interfaceBuilder.AppendLine($"        // {comment}");

                // Add all method signatures in the group without extra newlines
                foreach (var method in methodGroup)
                {
                    string returnType = method.Groups["returnType"].Value;
                    string methodName = method.Groups["methodName"].Value;
                    string parameters = method.Groups["parameters"].Value;

                    // Add method signature
                    interfaceBuilder.AppendLine($"        {returnType} {methodName}({parameters});");
                }

                // Add a blank line after each method group
                interfaceBuilder.AppendLine();
            }

            interfaceBuilder.AppendLine("    }");
            interfaceBuilder.AppendLine("}");

            // Write to output file and return content
            File.WriteAllText(outputFile, interfaceBuilder.ToString());
            return interfaceBuilder.ToString();
        }

        /// <summary>
        /// Converts a PascalCase method name to a human-readable comment
        /// </summary>
        private static string ConvertMethodNameToComment(string methodName)
        {
            // Remove room version naming
            methodName = methodName.Replace("R2", "").Replace("R1", "");

            // Split the method name into parts, handling acronyms
            var parts = new List<string>();
            var currentPart = new StringBuilder();

            for (int i = 0; i < methodName.Length; i++)
            {
                // Start a new part if:
                // 1. Current char is uppercase and previous was lowercase
                // 2. Current char is uppercase and next char is lowercase
                // 3. Transition from number to letter or vice versa
                if ((i > 0 && char.IsUpper(methodName[i]) && char.IsLower(methodName[i - 1])) ||
                    (i < methodName.Length - 1 && char.IsUpper(methodName[i]) && char.IsLower(methodName[i + 1])) ||
                    (i > 0 && char.IsDigit(methodName[i - 1]) != char.IsDigit(methodName[i])))
                {
                    // Add current accumulated part and start a new one
                    if (currentPart.Length > 0)
                    {
                        parts.Add(currentPart.ToString());
                        currentPart.Clear();
                    }
                }

                currentPart.Append(methodName[i]);
            }

            // Add last part
            if (currentPart.Length > 0)
            {
                parts.Add(currentPart.ToString());
            }

            // Known acronyms to keep uppercase
            string[] acronyms = { "SFX", "VR", "HUD", "AI", "UI", "HP", "MP", "URL", "ID" };

            // Transform parts
            return string.Join(" ", parts.Select(p =>
                acronyms.Contains(p.ToUpper()) ? p.ToUpper() :
                char.ToUpper(p[0]) + p.Substring(1).ToLower()));
        }
    }
}