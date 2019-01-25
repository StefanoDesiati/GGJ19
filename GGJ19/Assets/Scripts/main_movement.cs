using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"), 0)/7;
	}
}
