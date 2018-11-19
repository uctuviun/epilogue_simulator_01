using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rival_converse : MonoBehaviour {

	public bool inZone = false, windowOpen = false;
	public GameObject dialogue_1, dialogue_2, dialogue_3;
	public int duration;


	void Start () {

	}

	void Update () {
		if(inZone == true && Input.GetKeyDown("space") && !windowOpen &&
		PlayerPrefs.GetInt("talkedToRival") == 0){
			Instantiate(dialogue_1, new Vector2 (-100, -100), Quaternion.identity);
			windowOpen = true;
			PlayerPrefs.SetInt("talkedToRival", 1);
			StartCoroutine(TurnBackOff());
		}
		if(inZone == true && Input.GetKeyDown("space") && !windowOpen &&
		PlayerPrefs.GetInt("talkedToRival") == 1){
			Instantiate(dialogue_2, new Vector2 (-100, -100), Quaternion.identity);
			windowOpen = true;
			PlayerPrefs.SetInt("talkedToRival", 2);
			StartCoroutine(TurnBackOff());
		}
		if(inZone == true && Input.GetKeyDown("space") && !windowOpen &&
		PlayerPrefs.GetInt("talkedToRival") == 2){
			Instantiate(dialogue_3, new Vector2 (-100, -100), Quaternion.identity);
			windowOpen = true;
			PlayerPrefs.SetInt("talkedToRival", 0);
			StartCoroutine(TurnBackOff());
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
