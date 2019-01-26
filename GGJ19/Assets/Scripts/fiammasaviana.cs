using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fiammasaviana : MonoBehaviour {
	float time = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
		transform.position += new Vector3(-0.1f, 0, 0);
		if(time<0){
			Destroy(gameObject);
		}
	}
}
