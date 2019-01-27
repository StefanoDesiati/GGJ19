using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class danni : MonoBehaviour {
	public GameObject fegato2;
	public GameObject fegato3;
	int danno = 3;

	public void dannoRicevuto(){
		danno--;
		switch(danno){
			case 2:
				fegato3.SetActive(false);
			break;
			case 1:
				fegato2.SetActive(false);
			break;
			case 0:
        		SceneManager.LoadScene("loser");
			break;
		}
	}
}
