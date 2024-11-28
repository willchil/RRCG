﻿using RRCG;
using RRCG.Projects;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class RRCGMenu
{
    [MenuItem("RRCG/Create RRCG Prefab", priority = 1)]
    static void CreatePrefab()
    {
        Object prefab = Resources.Load("RRCG");

        GameObject instance = (GameObject) PrefabUtility.InstantiatePrefab(prefab);

        foreach (Transform child in instance.transform)
        {
            child.gameObject.hideFlags = HideFlags.HideInHierarchy;
        }

        Selection.activeObject = instance;
    }

    private const string AutoCompileEntry = "RRCG/Watch Mode";

    [MenuItem(AutoCompileEntry, priority = 20)]
    private static void ToggleAction()
    {
        RRCGScriptPreprocessor.AutoCompile = !RRCGScriptPreprocessor.AutoCompile;
    }

    [MenuItem(AutoCompileEntry, true, priority = 20)]
    private static bool ToggleActionValidate()
    {
        Menu.SetChecked(AutoCompileEntry, RRCGScriptPreprocessor.AutoCompile);
        return true;
    }

    [MenuItem("RRCG/Recompile All", priority = 20)]
    static void RecompileAll()
    {
        // Auto compile needs to be enabled for the asset importer to work
        var prevAutoCompile = RRCGScriptPreprocessor.AutoCompile;
        RRCGScriptPreprocessor.AutoCompile = true;

        var assets = AssetDatabase.FindAssets("rrcg").Select(AssetDatabase.GUIDToAssetPath).Where(path => path.EndsWith(".rrcg.cs"));
        foreach (var asset in assets)
        {
            AssetDatabase.ImportAsset(asset);
        }

        RRCGScriptPreprocessor.AutoCompile = prevAutoCompile;
    }

    [MenuItem("RRCG/Clean All", priority = 20)]
    static void CleanAll()
    {
        var assets = AssetDatabase.FindAssets("rrcg").Select(AssetDatabase.GUIDToAssetPath).Where(path => path.EndsWith(".rrcg.gen.cs"));
        foreach (var asset in assets)
        {
            AssetDatabase.DeleteAsset(asset);
        }

        StandaloneProjectManager.Clean();

        Debug.Log("Cleaned all!");
    }

    [MenuItem("RRCG/Regenerate RRCG Projects Solution", priority = 40)]
    static void RegenerateProjectsSolution()
    {
        StandaloneProjectManager.RegenerateSolution();

        // Is there a way to link to it?
        //Debug.Log("Solution regenerated! (<a href=\"RRCG\">Click here</a> to open)");
        Debug.Log("Solution regenerated!");
    }

    [MenuItem("RRCG/Clean RRCG Projects", priority = 40)]
    static void CleanProjectsSolution()
    {
        StandaloneProjectManager.Clean();
        Debug.Log("Projects cleaned!");
    }

    [MenuItem("RRCG/Graph Generator", priority = 20)]
    static void PromptWindow()
    {
        PromptWindow window = EditorWindow.GetWindow<PromptWindow>("Graph Generator Prompt");
        window.minSize = new Vector2(300, 200);
    }
}

