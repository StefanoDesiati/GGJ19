using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sputomadonne : MonoBehaviour {
public float speed = 2.0f;
	public float distance = 1;
	Vector3 pos;


	Transform tr;
	LayerMask lm;
	int rayh = 2;
	int rayv = 4;
	//Rigidbody2D rb2D;
	void Start () {
		pos = transform.position;
     	tr = transform;
     	lm = LayerMask.NameToLayer("Ostacolo");
     	//rb2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

     	/*else
     		Debug.Log(hitW.collider.gameObject.name);*/
		if(Input.GetKeyDown("joystick 1 button 0")){
			
			pos = Vector3.back;

		}

		else if (Input.GetAxis("Horizontal")>0.8f && tr.position == pos)  {
		RaycastHit2D hitD = Physics2D.Raycast(transform.position, Vector2.right, rayh, 1<<9);
			if(!(hitD.collider))
         		pos += Vector3.right * distance;
         	else //if(hitD.collider.gameObject.layer==10)
         		Debug.Log(hitD.collider.gameObject.layer);
     }
     else if (Input.GetAxis("Horizontal")<-0.8f && tr.position == pos) {
		RaycastHit2D hitA = Physics2D.Raycast(transform.position, Vector2.left, rayh, 1<<9);
			if(!(hitA.collider))
         		pos += Vector3.left * distance;
     }
     else if (Input.GetAxis("Vertical")>0.8f && tr.position == pos) {
		RaycastHit2D hitW = Physics2D.Raycast(transform.position, Vector2.up, rayv, 1<<9);
			if(!(hitW.collider))
         		pos += Vector3.up * distance;
     }
     else if (Input.GetAxis("Vertical")<-0.8f && tr.position == pos) {
		RaycastHit2D hitS = Physics2D.Raycast(transform.position, Vector2.down, rayv, 1<<9);
			if(!(hitS.collider))
         		pos += Vector3.down * distance;
     } 
     //Debug.Log(pos);
     transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
 }   
}
