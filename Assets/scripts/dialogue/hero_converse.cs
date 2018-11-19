using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero_converse : MonoBehaviour {


	public bool inZone = false, windowOpen = false;
	public GameObject dialogue_1, dialogue_2, dialogue_3;
	public int duration;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt("killedHero") == 0){
			if(inZone == true && Input.GetKeyDown("space") && !windowOpen &&
			PlayerPrefs.GetInt("talkedToHero") == 0){
				Instantiate(dialogue_1, new Vector2 (-100, -100), Quaternion.identity);
				windowOpen = true;
				PlayerPrefs.SetInt("talkedToHero", 1);
				StartCoroutine(TurnBackOff());
			}
			if(inZone == true && Input.GetKeyDown("space") && !windowOpen &&
			PlayerPrefs.GetInt("talkedToHero") == 1){
				Instantiate(dialogue_2, new Vector2 (-100, -100), Quaternion.identity);
				windowOpen = true;
				PlayerPrefs.SetInt("talkedToHero", 2);
				StartCoroutine(TurnBackOff());
			}
			if(inZone == true && Input.GetKeyDown("space") && !windowOpen &&
			PlayerPrefs.GetInt("talkedToHero") == 2){
				Instantiate(dialogue_3, new Vector2 (-100, -100), Quaternion.identity);
				windowOpen = true;
				PlayerPrefs.SetInt("talkedToHero", 0);
				StartCoroutine(TurnBackOff());
			}
		}
	}

	IEnumerator TurnBackOff(){
		yield return new WaitForSeconds(duration);
		windowOpen = false;
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
