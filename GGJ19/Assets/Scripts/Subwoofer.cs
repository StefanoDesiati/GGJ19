using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subwoofer : MonoBehaviour {
	public float countdown = 6f;
	float cd;
	public float duration = 1.2f;
	float activity;
	public GameObject cloud;
	// Use this for initialization
	void Start () {
		cd = countdown;
		activity = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space") & cd>=countdown){
			activity=duration;
			Instantiate(cloud,  this.gameObject.transform.GetChild(0).position, Quaternion.identity,  this.gameObject.transform.GetChild(0).transform);
			Instantiate(cloud,  this.gameObject.transform.GetChild(1).position, Quaternion.identity, this.gameObject.transform.GetChild(1).transform);
			Instantiate(cloud,  this.gameObject.transform.GetChild(2).position, Quaternion.identity, this.gameObject.transform.GetChild(2).transform);
			Instantiate(cloud,  this.gameObject.transform.GetChild(3).position, Quaternion.identity, this.gameObject.transform.GetChild(3).transform);
		}
		if (activity>0){
			activity-= Time.deltaTime;
		} else {
			if(this.gameObject.transform.GetChild(0).childCount>0){
			GameObject.Destroy(this.gameObject.transform.GetChild(0).GetChild(0).gameObject);	
			GameObject.Destroy(this.gameObject.transform.GetChild(1).GetChild(0).gameObject);	
			GameObject.Destroy(this.gameObject.transform.GetChild(2).GetChild(0).gameObject);	
			GameObject.Destroy(this.gameObject.transform.GetChild(3).GetChild(0).gameObject);	
			}
 			}
		

		if (cd < countdown){
			cd+=Time.deltaTime;
		}
	}
}
