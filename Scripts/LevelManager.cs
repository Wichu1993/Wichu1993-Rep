using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public float autoLoadNextLevelAfter;
    private Scene thisScene;
    
    private void Start()
    {
        thisScene = SceneManager.GetActiveScene();
        Debug.Log(thisScene.buildIndex);

        if (thisScene.buildIndex == 0)
        {
            Invoke("LoadNextLevel", autoLoadNextLevelAfter);
        }

    }

    public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(thisScene.buildIndex + 1);
    }

}
