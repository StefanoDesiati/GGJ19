using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridMovement : MonoBehaviour {
	bool triggerato =false;
	public float speed = 2.0f;
	public float distance_x;
	public float distance_y;

	GameObject foundcamera = null;
	public Transform pov;
	bool interact= false;
	public float secondi;
	 float secondipassati=0;
	int passifatti=0;
	public Vector3 pos;
	string buffer ="";
	float cont;
	Transform tr;
	
	Vector3 up1 = new Vector3(0.5f, 0.866f, 0);
	Vector3 down1 = new Vector3(-0.5f,-0.866f , 0);


	LayerMask lm;
	public float rayh = 8f;
	public float rayv = 4;

	danni danno;

	void Start () {
		
		pos = transform.position;
     	tr = transform;
		 lm = LayerMask.NameToLayer("Ostacolo");
		cont = 0;
		danno = gameObject.GetComponent<danni>();
	}
	
	// Update is called once per frame
	void Update () {
		if(foundcamera==null){
		
		
		cont=cont + Time.deltaTime;
		secondipassati+= Time.deltaTime;
		
		if(Input.GetKeyDown("joystick 1 button 2")){
			Debug.Log("HAI PREMUTO X");
			
		buffer="interact";

		}else if (Input.GetAxis("VerticalMain")>0.8f && tr.position == pos) {
		 RaycastHit2D hitW = Physics2D.Raycast(pov.position, up1, distance_y, 1<<9);
			if(!(hitW.collider))
        buffer="up";
		else if(hitW.collider.gameObject.tag == "porta")
			foundcamera =eureka();
		 //pos += Vector3.up * distance;
     }
	 else if (Input .GetAxis("VerticalMain")<-0.8f && tr.position == pos) {
		 RaycastHit2D hitS = Physics2D.Raycast(pov.position, down1, distance_y, 1<<9);
			if(!(hitS.collider))
         buffer="down";
		else if(hitS.collider.gameObject.tag == "porta")
		foundcamera =	eureka();
		 //pos += Vector3.down * distance;
     } 

		else if (Input.GetAxis("HorizontalMain")>0.8f && tr.position == pos ) {
			RaycastHit2D hitD = Physics2D.Raycast(pov.position, Vector2.right, distance_x, 1<<9);
			if(!(hitD.collider))
		buffer="right";
		else if(hitD.collider.gameObject.tag == "porta")
		foundcamera =	eureka();
			else
				Debug.Log("ROBERTO SAVIANO");
        // pos += Vector3.right * distance;
     }
     else if (Input.GetAxis("HorizontalMain")<-0.8f && tr.position == pos) {
		 RaycastHit2D hitA = Physics2D.Raycast(pov.position, Vector2.left, distance_x, 1<<9);
			if(!(hitA.collider))
         buffer="left";
		else if(hitA.collider.gameObject.tag == "porta")
		foundcamera =eureka();
			
		 //pos += Vector3.left * distance;
     }
     
     



     

		if(cont>=secondi){
			switch (buffer)
				{
					case "interact":
						Debug.Log("INTERAGISCI CON LE COSE");
						interact=false;
						buffer="";
						break;
					case "right":
						pos += Vector3.right * distance_x;
						buffer="";
						break;
					case "left":
						pos += Vector3.left * distance_x;
						buffer="";
						break;
					case "up":
					
						pos += up1 * distance_y;
						buffer="";
						break;
					case "down":
						pos += down1 * distance_y ;
						buffer="";
						break;
					default:
						buffer="";
						break;
				}




			
		passifatti+=1;
		//Debug.Log(passifatti);
		//Debug.Log(secondipassati);
		cont -= secondi;

		}
		transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
		}else{
			if (foundcamera!=null)
			foundcamera.transform.position = Vector3.Lerp(foundcamera.transform.position, new Vector3(19.2f, 0, -10), Time.deltaTime);
		}
		
 }
 void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.layer == 8)
        {
            Debug.Log("AHIA DIO BESTIA");
            if(col.gameObject.tag == "lampadariofo")
		        {
		        	//col.gameObject.GetComponent<lampadariofo>().collidato=true;
		        	//if(!col.gameObject.GetComponent<BoxCollider2D>().isTrigger){

		        				//danno--;
		            Debug.Log("AHIA DIO caprino");
		            		//col.gameObject.GetComponent<BoxCollider2D>().enabled = false;
				        	//timerFermoLampadario=1f;
		        //}
		        }
		        if(col.gameObject.tag == "onda"){
		            Debug.Log("me spinge viaaa");

		        }
		       // else
        	//danno--;
			danno.dannoRicevuto();
        }
		    }
   /*void OnTriggerExit2D(Collider2D other)
    {
		        	//Debug.Log("BEH DAI APPOSTO");
    	if(other.gameObject.tag == "lampadariofo")
		        {
			//other.gameObject.layer = 9;
		        	//Debug.Log("BEH DAI APPOSTO");
            		other.gameObject.GetComponent<BoxCollider2D>().enabled = true;
		        	//other.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
		        	//this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 20;
		        }
    }*/

	 GameObject eureka(){
		Transform camerapos;
		GameObject[] camera=  GameObject.FindGameObjectsWithTag("MainCamera");
		camerapos = camera[0].transform;
		 camerapos.position = new Vector3(19.2f, 0, -10);
		 camera[0].transform.position = Vector3.MoveTowards(camera[0].transform.position, camerapos.position, Time.deltaTime);
		 return camera[0];
		//this.transform.position=new Vector3(11.60f, -3.35f, 0);
		//pos=new Vector3(12.30f, -3.35f, 0);
	}
	}

