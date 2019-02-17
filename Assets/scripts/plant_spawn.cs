using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plant_spawn : MonoBehaviour {

	public bool inZone = false;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(inZone == true && PlayerPrefs.GetInt("seedlingUsing") == 1){
			PlayerPrefs.SetInt("seedlingUsed", 1);
		}
		if(PlayerPrefs.GetInt("seedlingUsed") == 1){
			(GetComponent<SpriteRenderer> ()).enabled = true;
			(GetComponent<Animator> ()).enabled = true;
			(GetComponent<AudioSource> ()).enabled = true;
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
