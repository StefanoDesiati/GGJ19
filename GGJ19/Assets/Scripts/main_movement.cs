using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_movement : MonoBehaviour {
	bool inv = false;
	
	public Sprite inv_main;
	public Sprite main;
	SpriteRenderer sprite1;
	public float inv_timer = 2.0f;
	float timeLeft;



	void Start () {
		  sprite1 = gameObject.GetComponent<SpriteRenderer>();
		  
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown("joystick 1 button 0") & (inv==false)    ){
		timeLeft=inv_timer;
		inv=true;
	}

	if (inv ==true){
		sprite1.sprite=inv_main;
		Vector3 scale = new Vector3( 1.8f, 1.4f, 1f );
    	transform.localScale = scale;
		timeLeft -= Time.deltaTime;
		if(timeLeft < 0){
			sprite1.sprite=main;
			scale = new Vector3( 0.6629f, 0.4366f, 1f );
			transform.localScale = scale;
			inv = false;
			}
	} else {
			transform.position += new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"), 0)/7;
			}
	}
}
