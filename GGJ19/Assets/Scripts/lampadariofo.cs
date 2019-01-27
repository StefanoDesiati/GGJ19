using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampadariofo : MonoBehaviour {
	float timerOrder = 0;
	public GameObject chungus;
	public bool collidato = false;
	Animator anim;
	Animator animSuolo;
	bool bona = false;
	bool scompari = false;
	float timeDesa;
	Vector3 pos = new Vector3(0, -400, 0);
	// Use this for initialization
	void Start () {
		anim = this.gameObject.transform.GetChild(0).GetComponent<Animator>();
		animSuolo = this.gameObject.transform.GetChild(1).GetComponent<Animator>();
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
		if (Input.GetKeyDown("joystick 2 button 3") || Input.GetKeyDown("return")){
			this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,1f);
			this.gameObject.GetComponent<BoxCollider2D>().enabled = true;

	        /*this.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;*/
			//timerOrder = 1f;
			//this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
			pos = transform.position-new Vector3(0, 4f, 0);
			bona = true;
			anim.SetBool("scende", true);
		}
		if(bona)
			transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * 8f);
		if(transform.position.y<=pos.y && !scompari){
			animSuolo.SetBool("suolotoccato", true);
			scompari = true;
			timeDesa = 0.50f;
		}
		if(scompari){
			timeDesa -= Time.deltaTime;
		}
		if(scompari && timeDesa<0){
			Debug.Log("c");
			this.gameObject.transform.parent.gameObject.SetActive(false);
		}

		Debug.Log(timeDesa);
	}
}
