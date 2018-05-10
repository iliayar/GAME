using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{

    public GameObject player; //цель камеры
     void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -20f);   
    }
}
   
