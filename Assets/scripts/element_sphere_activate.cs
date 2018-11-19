using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class element_sphere_activate : MonoBehaviour {

	public bool inZone = false;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if(inZone == true && PlayerPrefs.GetInt("elementMode") == 1){
			PlayerPrefs.SetInt("elementOn", 1);
		}
		if(inZone == true && PlayerPrefs.GetInt("elementMode") == 2){
			PlayerPrefs.SetInt("elementOn", 2);
		}
		if(inZone == true && PlayerPrefs.GetInt("elementMode") == 3){
			PlayerPrefs.SetInt("elementOn", 3);
		}

	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "player"){
			inZone = true;
		}
	}

	void OnTriggerExit2D(Collider2D col){
		if(col.gameObject.tag == "player"){
			inZone = false;
		}
	}
}
