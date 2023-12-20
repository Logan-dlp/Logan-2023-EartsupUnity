using UnityEditor;
using UnityEngine;

public class DisplayLogConsoleMenuItem
{
    [MenuItem("Tools/Log Console")]
    static void LogConsole()
    {
        Debug.Log(Selection.activeGameObject);
    }

    [MenuItem("Tools/Log Console", true)]
    static bool ValidateLogConsole()
    {
        return Selection.activeGameObject != null;
    }
}
