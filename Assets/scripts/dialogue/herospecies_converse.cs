using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class herospecies_converse : MonoBehaviour {


	public bool inZone = false, windowOpen = false;
	public GameObject dialogue_1, dialogue_2, dialogue_3, dialogue_4,
		dialogue_5, dialogue_6, dialogue_7;
	public int duration;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt("killedTown") == 0){
			if(inZone == true && Input.GetKeyDown("space") && !windowOpen &&
			PlayerPrefs.GetInt("talkedToHeroSpecies") == 0){
				Instantiate(dialogue_1, new Vector2 (-100, -100), Quaternion.identity);
				windowOpen = true;
				PlayerPrefs.SetInt("talkedToHeroSpecies", 1);
				StartCoroutine(TurnBackOff());
			}
			if(inZone == true && Input.GetKeyDown("space") && !windowOpen &&
			PlayerPrefs.GetInt("talkedToHeroSpecies") == 1){
				Instantiate(dialogue_2, new Vector2 (-100, -100), Quaternion.identity);
				windowOpen = true;
				PlayerPrefs.SetInt("talkedToHeroSpecies", 2);
				StartCoroutine(TurnBackOff());
			}
			if(inZone == true && Input.GetKeyDown("space") && !windowOpen &&
			PlayerPrefs.GetInt("talkedToHeroSpecies") == 2){
				Instantiate(dialogue_3, new Vector2 (-100, -100), Quaternion.identity);
				windowOpen = true;
				PlayerPrefs.SetInt("talkedToHeroSpecies", 3);
				StartCoroutine(TurnBackOff());
			}
			if(inZone == true && Input.GetKeyDown("space") && !windowOpen &&
			PlayerPrefs.GetInt("talkedToHeroSpecies") == 3){
				Instantiate(dialogue_4, new Vector2 (-100, -100), Quaternion.identity);
				windowOpen = true;
				PlayerPrefs.SetInt("talkedToHeroSpecies", 4);
				StartCoroutine(TurnBackOff());
			}
			if(inZone == true && Input.GetKeyDown("space") && !windowOpen &&
			PlayerPrefs.GetInt("talkedToHeroSpecies") == 4){
				Instantiate(dialogue_5, new Vector2 (-100, -100), Quaternion.identity);
				windowOpen = true;
				PlayerPrefs.SetInt("talkedToHeroSpecies", 5);
				StartCoroutine(TurnBackOff());
			}
			if(inZone == true && Input.GetKeyDown("space") && !windowOpen &&
			PlayerPrefs.GetInt("talkedToHeroSpecies") == 5){
				Instantiate(dialogue_6, new Vector2 (-100, -100), Quaternion.identity);
				windowOpen = true;
				PlayerPrefs.SetInt("talkedToHeroSpecies", 6);
				StartCoroutine(TurnBackOff());
			}
			if(inZone == true && Input.GetKeyDown("space") && !windowOpen &&
			PlayerPrefs.GetInt("talkedToHeroSpecies") == 6){
				Instantiate(dialogue_7, new Vector2 (-100, -100), Quaternion.identity);
				windowOpen = true;
				PlayerPrefs.SetInt("talkedToHeroSpecies", 0);
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
