using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScintillaVita : MonoBehaviour {
	float vita = 1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		vita -= Time.deltaTime;
		if(vita<0)
			Destroy(this.gameObject);
	}
}
