using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridMovement : MonoBehaviour {
	public float speed = 2.0f;
	public float distance = 1;
	bool interact= false;
	public int centisecondi;
	Vector3 pos;
	string buffer ="";
	float cont;
	Transform tr;

//roba raycast
	
	LayerMask lm;
	int rayh = 2;
	int rayv = 4;


	void Start () {
		pos = transform.position;
     	tr = transform;
		 
		cont = 0;

		//raycast
		lm = LayerMask.NameToLayer("Ostacolo");
	}
	
	// Update is called once per frame
	void Update () {
		
		cont=cont + 1 + Time.deltaTime;
		Debug.Log(cont);

		//raycast
		RaycastHit2D hitD = Physics2D.Raycast(transform.position, Vector2.right, rayh, 1<<9);
		RaycastHit2D hitA = Physics2D.Raycast(transform.position, Vector2.left, rayh, 1<<9);
		RaycastHit2D hitW = Physics2D.Raycast(transform.position, Vector2.up, rayv, 1<<9);
		RaycastHit2D hitS = Physics2D.Raycast(transform.position, Vector2.down, rayv, 1<<9);

		if(!(hitW.collider))
			Debug.Log("sjdhs");
			else
			Debug.Log(hitW.collider.gameObject.name);


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

		if(cont>centisecondi){
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

