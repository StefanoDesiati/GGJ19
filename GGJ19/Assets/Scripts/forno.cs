using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forno : MonoBehaviour {
	public GameObject prefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("joystick 2 button 2")){
			Instantiate(prefab, transform.position, Quaternion.identity);
		}
	}
}
