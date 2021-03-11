using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void LoadSceneByIndex(int sceneIndex)
    {
        Debug.Log("load scene 1");
        SceneManager.LoadScene(sceneIndex);
    }
        
}
