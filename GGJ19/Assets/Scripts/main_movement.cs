using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_movement : MonoBehaviour {
	bool inv = false;
	//public BoxCollider2D spritebase;
	//BoxCollider2D actualSize;
	//Vector3 scale;
	public GameObject cover;
	public float cooldown;
	public float cooldown_fake;


	float cd;

	float cd_fake;
	public Sprite inv_main;
	public Sprite main;
	//SpriteRenderer sprite1;
	public float inv_timer = 2.0f;
	float timeLeft;

	float timeLeft_fake;


	int danno = 3;
	float timerFermoLampadario = -1f;


	void Start () {
		 // sprite1 = gameObject.GetComponent<SpriteRenderer>();
		  cd = -1;
		 
	}
	
	// Update is called once per frame
	void Update () {
		if(timerFermoLampadario<0)
			transform.position += new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"), 0)/7;
	if (Input.GetKeyDown("joystick 1 button 0") & (inv==false) & (cd < 0)   ){
		timeLeft=inv_timer;
		cd=cooldown;
		Instantiate(cover, transform);
		inv=true;

	}

	if (inv ==true){
		
		//sprite1.sprite=inv_main;
		// scale = new Vector3( 1.8f, 1.4f, 1f );
    	//transform.localScale = scale;

		timeLeft -= Time.deltaTime;
		if(timeLeft < 0){
			//sprite1.sprite=main;
			//scale = new Vector3( 0.6629f, 0.4366f, 1f );
			//transform.localScale = scale;
			if (transform.childCount > 0){
			 Destroy(transform.GetChild(0).gameObject);
			}
			inv = false;
			}
	} 
	if(timerFermoLampadario>=0)
	timerFermoLampadario -= Time.deltaTime;

	if(danno==0)
		Debug.Log("ue fra sei morto");
	//else {
	//		
	//		}


if (Input.GetKeyDown("joystick 1 button 1")){
	inv_fake(cd_fake, inv);

}
	
//la posizione di questo potrebbe causare sovrapposizione di stati in futuro, who knows
	if((timeLeft_fake<0) &(inv==false)){
		//sprite1.sprite=main;
		//	scale = new Vector3( 0.6629f, 0.4366f, 1f );
		//	transform.localScale = scale;
		//	spritebase.size=actualSize.size;
		if (transform.childCount > 0)
		 Destroy(transform.GetChild(0).gameObject);
	}else{

	
	timeLeft_fake-=Time.deltaTime;
	}







	if(cd>=0)
	cd -= Time.deltaTime;

	if(cd_fake>=0)
	cd_fake -=Time.deltaTime;



	
	}
	
	


	void inv_fake (float cd_fakeCheck, bool inv){
		if( (inv==false) & (cd_fakeCheck < 0)){
			//sprite1.sprite=inv_main;
		//	Vector3 scale = new Vector3( 1.8f, 1.4f, 1f );
    	//	transform.localScale = scale;
			Instantiate(cover, transform);
			cd_fake=cooldown_fake;
			timeLeft_fake=inv_timer;
		}

	}
	void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.layer == 8)
        {
            Debug.Log("AHIA DIO BESTIA");
            if(col.gameObject.tag == "Lampadariofo")
		        {
		        	if(!col.gameObject.GetComponent<BoxCollider2D>().isTrigger){

		        				danno--;
		            Debug.Log("AHIA DIO caprino");
		            		//col.gameObject.GetComponent<BoxCollider2D>().enabled = false;
				        	timerFermoLampadario=1f;
		        }
		        }
		        else
        	danno--;
        }
    }void OnTriggerExit2D(Collider2D other)
    {
		        	Debug.Log("BEH DAI APPOSTO");
    	if(other.gameObject.tag == "lampadariofo")
		        {
		        	Debug.Log("BEH DAI APPOSTO");
            		other.gameObject.GetComponent<BoxCollider2D>().enabled = true;
		        	other.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
		        	this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 20;
		        }
    }
}
