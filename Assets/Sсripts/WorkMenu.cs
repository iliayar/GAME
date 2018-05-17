using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkMenu : MonoBehaviour {
    public GameObject settings;
    public void StartGame()
    {
        Application.LoadLevel("var_1");
    }

    public void Settings()
    {
        settings.SetActive(!settings.activeSelf);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
