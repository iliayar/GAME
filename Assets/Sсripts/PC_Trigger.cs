using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PC_Trigger : MonoBehaviour
{

    public GameObject text;

    public GameObject player;

    void Start()
    {
        text.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
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
        if (col.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (SceneManager.GetActiveScene().name != "var_1") return;
                SceneManager.LoadScene("PC_v2", LoadSceneMode.Additive);
            }
        }
    }
}
