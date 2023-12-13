using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomComponent : MonoBehaviour
{
    [SerializeField, Scene] int _scene;

    [ContextMenu("Load Scene")]
    private void LoadScene()
    {
        if (Application.isPlaying)
        {
            SceneManager.LoadScene(_scene);
        }
        else
        {
            string scenePath = SceneManager.GetSceneByBuildIndex(_scene).path;
            EditorSceneManager.OpenScene(scenePath);
        }
    }
}
