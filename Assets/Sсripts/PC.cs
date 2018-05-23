using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PC : MonoBehaviour
{
    public Text PCText;
    public int StringFirstSign = 1;

    // Use this for initialization
    void Start()
    {
        PCText.text = ">";

        SceneManager.SetActiveScene(SceneManager.GetSceneByName("PC"));
    }

    // Update is called once per frame


    void Update()
    {

     
        foreach (char c in Input.inputString)
        {
            if (c == '\b')
            {
                if (PCText.text.Length - 1 >= StringFirstSign)
                    PCText.text = PCText.text.Substring(0, PCText.text.Length - 1);
            }
            else if ((c == '\n') || (c == '\r'))
            {
                PCText.text += "\n";
                string command = PCText.text.Substring(StringFirstSign, PCText.text.Length - StringFirstSign - 1);


                switch (command)
                {
                    case "h":
                    case "?":
                    case "help":
                        PCText.text += "help - Show this message\n";
                        PCText.text += "files - Watch files\n";
                        PCText.text += "<finename> - print out file\n";
                        PCText.text += "exit - Close terminal";
                        PCText.text += "\n>";
                        StringFirstSign = PCText.text.Length;
                        break;
                    case "files":
                        PCText.text += "01.03.!!\n";
                        PCText.text += "26.03.!!\n";
                        PCText.text += "11.04.!!\n";
                        PCText.text += "request\n";
                        PCText.text += "25.05.!!\n";
                        PCText.text += "09.05.!!\n";
                        PCText.text += "automatic_dispatch";
                        PCText.text += "\n>";
                        StringFirstSign = PCText.text.Length;
                        break;
                    case "01.03.!!":
                        PCText.text += "DATA_CORRUPTED";
                        PCText.text += "\n>";
                        StringFirstSign = PCText.text.Length;
                        break;
                    case "26.03.!!":
                        PCText.text += "Эксперименты идут успешно.Объе/т ;№#?' -!ост массы в 5 раз, преобразование идет по графи[>";
                        PCText.text += "\n>";
                        StringFirstSign = PCText.text.Length;
                        break;
                    case "11.04.!!":
                        PCText.text += "'1s ,d!охо идут на конттакт. Наблюдаютсяя глоссалии,умjsdf2-#20ие тпламуса в 2.3 раза";
                        PCText.text += "\n>";
                        StringFirstSign = PCText.text.Length;
                        break;
                    case "request":
                        PCText.text += "_ужен материал. Закажин шту*-0!,wf@ерам плоти";
                        PCText.text += "\n>";
                        StringFirstSign = PCText.text.Length;
                        break;
                    case "25.05.!!":
                        PCText.text += "DATA_CORRUPTED";
                        PCText.text += "\n>";
                        StringFirstSign = PCText.text.Length;
                        break;
                    case "09.05.!!":
                        PCText.text += "Через покажем |DELETED| продукт.Надо доделать презентацию";
                        PCText.text += "\n>";
                        StringFirstSign = PCText.text.Length;
                        break;
                    case "automatic_dispatch":
                        PCText.text += "ВНИМАНИЕ!НАРУШЕНА ЦЕЛОСТНОСТЬ КАМЕР СОДЕРЖАНИЯ СЕКТОРА С!ВСЕМ СОТРУДНИКАМ ИДТИ К ТОЧКАМ ЭВ{{}нас";
                        PCText.text += "\n>";
                        StringFirstSign = PCText.text.Length;
                        break;
                    case "exit":
                    case "quit":
                        SceneManager.UnloadSceneAsync("PC");
                        break;
                    default:
                        PCText.text += "Unknown command";
                        PCText.text += "\n>";
                        StringFirstSign = PCText.text.Length;
                        break;
                }



            }
            else
            {
                PCText.text += c;
            }
        }

    }
}
