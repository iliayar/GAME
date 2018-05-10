using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMovement : MonoBehaviour {
    public GameObject Heroy;
    private Vector3 ofset;
	
	void Start () {
        ofset = transform.position - Heroy.transform.position;
	}
	
	
	void LateUpdate () {
        transform.position = Heroy.transform.position + ofset;
	}
}
