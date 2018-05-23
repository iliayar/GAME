using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {


    public Animator anim;
    private AudioSource Open;
	void Start () {
        Open = GetComponent<AudioSource>();
	}
	
	
	void Update () {

	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            if(ApplicationModel.power_state && ApplicationModel.entrance_state)
            {
                anim.Play("opening");
                Open.Play();
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
