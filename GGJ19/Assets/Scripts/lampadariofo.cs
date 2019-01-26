using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampadariofo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")){
			this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,1f);
			this.gameObject.GetComponent<BoxCollider2D>().enabled = true;
			//this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
		}
	}
}
