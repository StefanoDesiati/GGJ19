using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridMovement : MonoBehaviour {
	public float speed = 2.0f;
	public float distance = 1;
	Vector3 pos;


	Transform tr;
	void Start () {
		pos = transform.position;
     	tr = transform;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown("joystick 1 button 0")){
			
			pos = Vector3.back;

		}

		else if (Input.GetAxis("Horizontal")>0.8f && tr.position == pos ) {
		
         pos += Vector3.right * distance;
     }
     else if (Input.GetAxis("Horizontal")<-0.8f && tr.position == pos) {
         pos += Vector3.left * distance;
     }
     else if (Input.GetAxis("Vertical")>0.8f && tr.position == pos) {
         pos += Vector3.up * distance;
     }
     else if (Input.GetAxis("Vertical")<-0.8f && tr.position == pos) {
         pos += Vector3.down * distance;
     } 
     Debug.Log(pos);
     transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
 }   
	}

