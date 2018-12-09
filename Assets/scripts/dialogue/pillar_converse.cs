using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pillar_converse : MonoBehaviour {

	public bool inZone = false;
	public bool p_one, p_two, p_three, p_four, p_five, p_six, p_seven, p_eight,
		p_nine, p_ten, p_eleven, p_twelve, p_thirteen;
	public GameObject dialogue;

	// Use this for initialization
	void Start () {


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

	// Update is called once per frame
	void Update () {
		if (p_one){
			if(PlayerPrefs.GetInt("pillarOne") == 0){
				if(inZone == true && Input.GetKeyDown("space")){
					Instantiate(dialogue, new Vector2 (-100, -100), Quaternion.identity);
					PlayerPrefs.SetInt("pillarOne", 1);
				}
			}
		}	


	}


}
