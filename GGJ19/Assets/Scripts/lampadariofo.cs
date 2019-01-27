using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampadariofo : MonoBehaviour {
	float timerOrder = 0;
	public GameObject chungus;
	public bool collidato = false;
	bool bona = false;
	Vector3 pos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		/*if(timerOrder>0){
			timerOrder -=Time.deltaTime;
			if(timerOrder<=0 && !collidato){
				chungus.GetComponent<SpriteRenderer>().sortingOrder = 20;
        		this.gameObject.GetComponent<BoxCollider2D>().enabled = true;
	        	this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;

			}
		}*/
		if (Input.GetKeyDown("joystick 2 button 3")){
			this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,1f);
			this.gameObject.GetComponent<BoxCollider2D>().enabled = true;
	        /*this.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;*/
			//timerOrder = 1f;
			//this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
			pos = transform.position-new Vector3(0, 4f, 0);
			bona = true;
		}
		if(bona)
			transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * 8f);
	}
}
