using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

[CustomEditor(typeof(CustomEditorComponent))]
public class CustomEditorComponentEditor : Editor
{
    private SerializedProperty sampleTextProp;
    private SerializedProperty sceneIndexProp;

    private void OnEnable()
    {
        sampleTextProp = serializedObject.FindProperty("_sampleText");
        sceneIndexProp = serializedObject.FindProperty("_sceneIndex");
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        using (new EditorGUILayout.HorizontalScope())
        {
            if (GUILayout.Button("-1"))
            {
                sceneIndexProp.intValue--;
                SceneManager.GetSceneByBuildIndex(sceneIndexProp.intValue);
            }
            if (GUILayout.Button("+1"))
            {
                sceneIndexProp.intValue++;
                SceneManager.GetSceneByBuildIndex(sceneIndexProp.intValue);
            }
        }
        EditorGUILayout.LabelField(sampleTextProp.stringValue);

        serializedObject.ApplyModifiedProperties();
    }
}