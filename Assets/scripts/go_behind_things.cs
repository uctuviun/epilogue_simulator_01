using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go_behind_things : MonoBehaviour {

	Renderer renderer;
	public bool inZone = false;
	public bool villager;

	// Use this for initialization
	void Start () {
//		renderer.sortingOrder = -1;
		renderer = GetComponent<Renderer> ();
		if (villager == true){
			renderer = gameObject.GetComponentInParent<Renderer>();
		}

	}

	// Update is called once per frame
	void Update () {
		if(inZone == true){
			renderer.sortingOrder = 1;
		}
		if(inZone == false){
			renderer.sortingOrder = -1;
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
