using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class core_tile_activator : MonoBehaviour {

	public bool inZone = false;
	public GameObject draw_screen, reset;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(inZone == true && PlayerPrefs.GetInt("blackCardUsing") == 1){
			PlayerPrefs.SetInt("blackCardUsed", 1);
		}
		if(inZone == true && PlayerPrefs.GetInt("whiteCardUsing") == 1){
			PlayerPrefs.SetInt("whiteCardUsed", 1);
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "player"){
			inZone = true;
			if(PlayerPrefs.GetInt("whiteCardUsed") == 1 && PlayerPrefs.GetInt("blackCardUsed") == 1 &&
				PlayerPrefs.GetInt("ancientHeroOver") == 1){
					Instantiate(draw_screen, new Vector2(-100, -100), Quaternion.identity);
					PlayerPrefs.SetInt("freeze", 1);
					PlayerPrefs.SetInt("gameOver", 1);
					Instantiate(reset, new Vector2 (-200, -200), Quaternion.identity);
				}
		}
	}

	void OnTriggerExit2D(Collider2D col){
		if(col.gameObject.tag == "player"){
			inZone = false;
			if(PlayerPrefs.GetInt("whiteCardUsed") == 1 && PlayerPrefs.GetInt("blackCardUsed") == 1 &&
				PlayerPrefs.GetInt("ancientHeroOver") == 1){
					Instantiate(draw_screen, new Vector2(-100, -100), Quaternion.identity);
					PlayerPrefs.SetInt("freeze", 1);
					PlayerPrefs.SetInt("gameOver", 1);
					Instantiate(reset, new Vector2 (-200, -200), Quaternion.identity);
				}
		}
	}
}
