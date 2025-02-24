using UnityEngine;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
   public void LoadSceneWithName(string sceneName) 
    {
        SceneManager.LoadScene(sceneName);
    }
}
