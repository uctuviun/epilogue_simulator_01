using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show_selector : MonoBehaviour {

	SpriteRenderer renderer;

	// Use this for initialization
	void Start () {
		renderer = GetComponent<SpriteRenderer> ();

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "player"){
			renderer.enabled = true;
		}
	}

	void OnTriggerExit2D(Collider2D col){
		if(col.gameObject.tag == "player"){
			renderer.enabled = false;
		}
	}
}
