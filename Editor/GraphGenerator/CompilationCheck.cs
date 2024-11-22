using System;
using System.CodeDom.Compiler;
using System.Linq;
using Microsoft.CSharp;
using UnityEngine;

public static class CodeValidator
{
    /// <summary>
    /// Checks if the provided C# code compiles.
    /// </summary>
    /// <param name="code">The C# code to check.</param>
    /// <param name="errorMessages">An array of error messages if compilation fails.</param>
    /// <returns>True if the code compiles without errors; otherwise, false.</returns>
    public static bool IsCodeCompilable(string code, out string[] errorMessages)
    {
        // Create a C# code provider
        using (var codeProvider = new CSharpCodeProvider())
        {
            // Set up the parameters for compilation
            var parameters = new CompilerParameters
            {
                GenerateExecutable = false, // We just want to compile a library (or in-memory assembly)
                GenerateInMemory = true,
                TreatWarningsAsErrors = true,
            };

            // Add references to required assemblies.
            // This list might need to be extended depending on what your generated code requires.
            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("System.Core.dll");

            string unityEnginePath = typeof(UnityEngine.Object).Assembly.Location;
            string rrcgCorePath = typeof(RRCG.RRCG).Assembly.Location;

            // Add necessary references
            parameters.ReferencedAssemblies.Add(unityEnginePath);
            parameters.ReferencedAssemblies.Add(rrcgCorePath);

            // Compile the code in memory
            CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, code);

            // If there are errors, collect them and return false.
            if (results.Errors.HasErrors)
            {
                errorMessages = results.Errors
                    .Cast<CompilerError>()
                    .Select(error => $"Line {error.Line}: {error.ErrorText}")
                    .ToArray();

                // For debugging purposes, you might want to log the errors:
                foreach (var error in errorMessages)
                {
                    Debug.LogError(error);
                }
                return false;
            }

            // No errors, code is compilable.
            errorMessages = new string[0];
            return true;
        }
    }
}
