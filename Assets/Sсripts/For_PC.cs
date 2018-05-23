using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class For_PC : MonoBehaviour {
    public GameObject notes;
    public GameObject alerts;
    public GameObject menu;
    public GameObject notesnomber1;
    public GameObject notesnomber2;
    public GameObject notesnomber3;
    public GameObject notesnomber4;
    public GameObject notesnomber5;
    public GameObject notesnomber6;
    public GameObject alertsnomber1;
    public GameObject alertsnomber2;
    void Start()
    {
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("PC"));
    }
    public void Notes()
    {
        notes.SetActive(!notes.activeSelf);
        menu.SetActive(!menu.activeSelf);
    }
    public void Alerts()
    {
        alerts.SetActive(!alerts.activeSelf);
        menu.SetActive(!menu.activeSelf);

    }
    public void Exit()
    {
        SceneManager.UnloadScene("PC_v2");
        
    }
    public void NotesNomber1()
    {
        notesnomber1.SetActive(!notesnomber1.activeSelf);
    }
    public void NotesNomber2()
    {
        notesnomber2.SetActive(!notesnomber2.activeSelf);
    }
    public void NotesNomber3()
    {
        notesnomber3.SetActive(!notesnomber3.activeSelf);
    }
    public void NotesNomber4()
    {
        notesnomber4.SetActive(!notesnomber4.activeSelf);
    }
    public void NotesNomber5()
    {
        notesnomber5.SetActive(!notesnomber5.activeSelf);
    }
    public void NotesNomber6()
    {
        notesnomber6.SetActive(!notesnomber6.activeSelf);
    }
    public void AlertsNomber1()
    {
        alertsnomber1.SetActive(!alertsnomber1.activeSelf);
    }
    public void AlertsNomber2()
    {
        alertsnomber2.SetActive(!alertsnomber2.activeSelf);
    }
}
