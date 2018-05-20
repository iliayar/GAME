using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {


    public Animator anim;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            if(ApplicationModel.power_state && ApplicationModel.entrance_state)
            {
                anim.Play("opening");
            }

        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            if (ApplicationModel.power_state && ApplicationModel.entrance_state)
            {
                anim.Play("closing");
            }

        }
    }
}
