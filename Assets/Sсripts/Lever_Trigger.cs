using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lever_Trigger : MonoBehaviour
{
    public GameObject AM;

    public GameObject text;

    public GameObject player;

    public Sprite LeverOff;
    public Sprite LeverOn;

    public SpriteRenderer Source;

    public bool state = false;

    public Terminal_Trigger script;

    private AudioSource Electricity;
    void Start()
    {
        text.SetActive(false);
        Electricity = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(state)
        {
            Source.sprite = LeverOn;
            script.power_state = true;
            ApplicationModel.power_state = true;
        } else
        {
            Source.sprite = LeverOff;
            script.power_state = false;
            ApplicationModel.power_state = false;
        }
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
                Electricity.Play();
                state = !state;
            }
        }
    }
}

public class ApplicationModel
{
    public static bool power_state = false;
    public static bool entrance_state = false;
}