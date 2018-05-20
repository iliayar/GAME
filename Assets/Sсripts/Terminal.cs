using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Terminal : MonoBehaviour {

    public Text TermText;
    public int StringFirstSign = 0;
    public string WaitingType = "";
    public string TruePasswd;
    public bool power_state;
    public bool entrance_state;

    public SpriteRenderer Terminal_SpriteRenderer;

    public Sprite Term;
    public Sprite Term_P;
    public Sprite Term_E;
    public Sprite Term_PE;
    // Use this for initialization
    void Start () {
        TermText = GetComponent<Text>();

        TermText.text = ">";

        SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(0));

        power_state = ApplicationModel.power_state;
        entrance_state = ApplicationModel.entrance_state;
    }

    // Update is called once per frame


    void Update()
    {



        if (power_state) {
            if (entrance_state)
            {
                Terminal_SpriteRenderer.sprite = Term_PE;
            } else
            {
                Terminal_SpriteRenderer.sprite = Term_P;
            }
        } else
        {
            if(entrance_state)
            {
                Terminal_SpriteRenderer.sprite = Term_E;
            }
            else
            {
                Terminal_SpriteRenderer.sprite = Term;
            }
        }

        foreach (char c in Input.inputString)
        {
            if (c == '\b')
            {   
                if(TermText.text.Length - 1 >= StringFirstSign)
                    TermText.text = TermText.text.Substring(0, TermText.text.Length - 1);
            }
            else if ((c == '\n') || (c == '\r')) 
            {
                TermText.text += "\n";
                string command = TermText.text.Substring(StringFirstSign, TermText.text.Length - StringFirstSign - 1);

                if (WaitingType == "passwd")
                {
                    WaitingType = "";
                    if(command == TruePasswd)
                    {
                        entrance_state = true;
                        ApplicationModel.entrance_state = true;
                        TermText.text += "Correct password!";
                    } else
                    {
                        TermText.text += "Incorrect password!";
                    }
                    TermText.text += "\n>";
                    StringFirstSign = TermText.text.Length;
                    continue;
                }
                else
                {
                    TermText.text += "Executing: " + command + '\n';
                }
                switch(command)
                {
                    case "h":
                    case "?":
                    case "help":
                        TermText.text += "help - Show this message\n";
                        TermText.text += "unlock - Unlock door using password\n";
                        TermText.text += "lock - Lock door\n";
                        TermText.text += "exit - Close terminal";
                        TermText.text += "\n>";
                        StringFirstSign = TermText.text.Length;
                        break;

                    case "lck":
                    case "lock":
                        entrance_state = false;
                        TermText.text += "Locked!";
                        TermText.text += "\n>";
                        StringFirstSign = TermText.text.Length;
                        ApplicationModel.entrance_state = false;
                        break;

                    case "unlck":
                    case "unlock":
                    case "ulock":
                    case "ulck":
                        WaitingType = "passwd";
                        TermText.text += "Enter password: ";
                        StringFirstSign = TermText.text.Length;
                        break;

                    case "exit":
                    case "quit":
                        SceneManager.UnloadScene("Terminal_scene");
                        break;
                    default:
                        TermText.text += "Unknown command";
                        TermText.text += "\n>";
                        StringFirstSign = TermText.text.Length;
                        break;
                }



            }
            else
            {
                TermText.text += c;
            }
        }

    }
}
