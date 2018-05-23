using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_menu : MonoBehaviour {

    public void Return()
    {
        SceneManager.UnloadSceneAsync("Play_menu");
    }

    public void MainMenu()
    {
        SceneManager.UnloadSceneAsync("var_1");
        SceneManager.UnloadSceneAsync("Play_menu");
        SceneManager.LoadScene("Menu");
    }
}
