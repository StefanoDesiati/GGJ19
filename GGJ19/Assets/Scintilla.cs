using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scintilla : MonoBehaviour {
	float spawn = 3f;
	public GameObject prefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		spawn -= Time.deltaTime;
		if(spawn<0){
			Instantiate(prefab, transform.position + new Vector3(0.5f,0.65f,0), Quaternion.identity);
			spawn += 3f;
		}
	}
}
