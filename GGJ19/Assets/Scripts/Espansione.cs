using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espansione : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

			if(transform.localScale.x<51 && transform.localScale.y<24)
				transform.localScale += new Vector3(17, 8, 0)*0.05f;
			else
				Destroy(this.gameObject);
	}
}
