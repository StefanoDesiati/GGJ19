using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invulnerabilità : MonoBehaviour {
	public bool inv = false;
	public GameObject cover;
	public bool avaiability = true;
	public bool avaiability_fake = true;
	float cd;

	float cd_fake;
	public Sprite inv_main;
	public Sprite main;
	public float inv_timer = 2.0f;
	float timeLeft;

	float timeLeft_fake;
	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown("joystick 1 button 0") && (avaiability==true)     ){
		Debug.Log("AAAAAAAA");
		Instantiate(cover, transform);
		Debug.Log("DOVREI AVER CREATO");
		timeLeft=inv_timer;
		avaiability=false;
		
		inv=true;

	} 
	 if (inv==true){
		
		//sprite1.sprite=inv_main;
		// scale = new Vector3( 1.8f, 1.4f, 1f );
    	//transform.localScale = scale;

		timeLeft -= Time.deltaTime;
		Debug.Log(timeLeft);
		if(timeLeft < 0){
			
			//sprite1.sprite=main;
			//scale = new Vector3( 0.6629f, 0.4366f, 1f );
			//transform.localScale = scale;
			if (transform.childCount > 1){
				
			 Destroy(transform.GetChild(1).gameObject);
			 inv = false;
			}
			
			}
	}

if (Input.GetKeyDown("joystick 1 button 1")){
	inv_fake(inv);

}
if((timeLeft_fake<0)&&(inv==false)){
	
		//sprite1.sprite=main;
		//	scale = new Vector3( 0.6629f, 0.4366f, 1f );
		//	transform.localScale = scale;
		//	spritebase.size=actualSize.size;
		if (transform.childCount > 1)
		 Destroy(transform.GetChild(1).gameObject);
	}else{

	
	timeLeft_fake-=Time.deltaTime;
	}


	}


void inv_fake (bool inv){
		if( (inv==false)&&(avaiability_fake==true)){
			
			//sprite1.sprite=inv_main;
		//	Vector3 scale = new Vector3( 1.8f, 1.4f, 1f );
    	//	transform.localScale = scale;
			Instantiate(cover, transform);
			avaiability_fake=false;;
			timeLeft_fake=inv_timer;
		}

	}








}
