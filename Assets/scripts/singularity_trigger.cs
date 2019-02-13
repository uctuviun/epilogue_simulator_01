using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class singularity_trigger : MonoBehaviour {

	public bool inZone = false;
	public GameObject release, endscreen, reset;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(inZone == true && PlayerPrefs.GetInt("orangePlayer") == 1){
			Instantiate(release, transform.position, Quaternion.identity);
			Instantiate(endscreen, new Vector2(-100, -100), Quaternion.identity);
			PlayerPrefs.SetInt("freeze", 1);
			PlayerPrefs.SetInt("gameOver", 1);
			Instantiate(reset, new Vector2 (-200, -200), Quaternion.identity);
			Destroy(gameObject);
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
