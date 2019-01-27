	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woofCloud : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	 void OnTriggerEnter2D(Collider2D other)
    {
		if(other.gameObject.name=="Chungus"){
			if (this.gameObject.transform.parent.name == "woofN"){
				RaycastHit2D hitD = Physics2D.Raycast(gameObject.transform.position, new Vector2(0.5f, 0.866f), 1.5711f, 1<<9);
				if(!(hitD.collider)){
					other.gameObject.GetComponent<gridMovement>().pos+= new Vector3(0.5f, 0.866f,0) * 1.5711f;
				}

			}

			if (this.gameObject.transform.parent.name == "woofE"){
				RaycastHit2D hitD = Physics2D.Raycast(gameObject.transform.position,  Vector2.right, 3.253f, 1<<9);
				if(!(hitD.collider)){
					other.gameObject.GetComponent<gridMovement>().pos+= Vector3.right * 3.253f;
				}

			}
			if (this.gameObject.transform.parent.name == "woofS"){
				RaycastHit2D hitD = Physics2D.Raycast(gameObject.transform.position, new Vector2(-0.5f, -0.866f), 1.5711f, 1<<9);
				if(!(hitD.collider)){
					other.gameObject.GetComponent<gridMovement>().pos+= new Vector3(-0.5f, -0.866f,0) * 1.5711f;
				}
			}
			if (this.gameObject.transform.parent.name == "woofW"){
				RaycastHit2D hitD = Physics2D.Raycast(gameObject.transform.position,  Vector2.left, 3.253f, 1<<9);
				if(!(hitD.collider)){
					other.gameObject.GetComponent<gridMovement>().pos+= Vector3.left * 3.253f;
				}

			}
		}
        
    }
}
