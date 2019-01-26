using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridMovement : MonoBehaviour {
	public float speed = 2.0f;
	public float distance = 1;
	bool interact= false;
	public float secondi;
	Vector3 pos;
	string buffer ="";
	float cont;
	Transform tr;
	void Start () {
		pos = transform.position;
     	tr = transform;
		cont = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
		cont=cont + Time.deltaTime;
		Debug.Log(cont);
		if(Input.GetKeyDown("joystick 1 button 0")){
			
		buffer="interact";

		}

		else if (Input.GetAxis("Horizontal")>0.8f && tr.position == pos ) {
		buffer="right";
        // pos += Vector3.right * distance;
     }
     else if (Input.GetAxis("Horizontal")<-0.8f && tr.position == pos) {
         buffer="left";
		 //pos += Vector3.left * distance;
     }
     else if (Input.GetAxis("Vertical")>0.8f && tr.position == pos) {
        buffer="up";
		 //pos += Vector3.up * distance;
     }
     else if (Input.GetAxis("Vertical")<-0.8f && tr.position == pos) {
         buffer="down";
		 //pos += Vector3.down * distance;
     } 

     Debug.Log(pos);

		if(cont>secondi){
			switch (buffer)
				{
					case "interact":
						Debug.Log("INTERAGISCI CON LE COSE");
						interact=false;
						buffer="";
						break;
					case "right":
						pos += Vector3.right * distance;
						buffer="";
						break;
					case "left":
						pos += Vector3.left * distance;
						buffer="";
						break;
					case "up":
						pos += Vector3.up * distance;
						buffer="";
						break;
					case "down":
						pos += Vector3.down * distance;
						buffer="";
						break;
					default:
						buffer="";
						break;
				}




			
			
		cont = 0;
		
		}
		transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
 }   
	}

