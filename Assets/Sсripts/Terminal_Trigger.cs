using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Terminal_Trigger : MonoBehaviour {

    public GameObject text;

    public GameObject player;

    public bool power_state = false;
    public bool entrance_state = false;

    void Start()
    {
        text.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            text.SetActive(true);
            
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            text.SetActive(false);
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                if (SceneManager.GetActiveScene().name != "var_1") return;
                SceneManager.LoadScene("Terminal_scene",LoadSceneMode.Additive);
            }
        }
    }
}
