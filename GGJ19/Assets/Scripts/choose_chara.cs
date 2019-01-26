using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choose_chara : MonoBehaviour {
	string player1 ="";
		string house ="";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
    if (Input.GetKeyDown("joystick 1 button 0")) {
       player1 = "joystick 1";
	    Debug.Log ("player è 1");
    }


	if (Input.GetKeyDown("joystick 2 button 0")) {
       player1 = "joystick 2";
	    Debug.Log ("player è 2");
    }

	if (Input.GetKeyDown("joystick 1 button 1")) {
       house = "joystick 1";
	    Debug.Log ("casa è 1");
    }
if (Input.GetKeyDown("joystick 2 button 1")) {
       house = "joystick 2";
	   Debug.Log ("casa è 2");
    }

	}
}
