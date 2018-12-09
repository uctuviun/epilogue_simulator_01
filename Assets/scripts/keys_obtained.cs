using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keys_obtained : MonoBehaviour {

	SpriteRenderer renderer;
	public bool is_q, is_e, is_r, is_y, is_u, is_o, is_p;
	public Sprite halfway, fully;

	// Use this for initialization
	void Start () {
		renderer = GetComponent<SpriteRenderer> ();
	}


	// Update is called once per frame
	void Update () {

		if (is_q){
			if(PlayerPrefs.GetInt("rivalItemsParts") == 0){
				renderer.enabled = false;
			}
			if(PlayerPrefs.GetInt("rivalItemsParts") == 1 || PlayerPrefs.GetInt("rivalItemsParts") == 2){
				renderer.enabled = true;
				renderer.sprite = halfway;
			}
			if(PlayerPrefs.GetInt("rivalItemsParts") == 3){
				renderer.enabled = true;
				renderer.sprite = fully;
			}
		}
		if (is_e){
			if(PlayerPrefs.GetInt("rivalSpellsParts") == 0){
				renderer.enabled = false;
			}
			if(PlayerPrefs.GetInt("rivalSpellsParts") == 1 || PlayerPrefs.GetInt("rivalSpellsParts") == 2){
				renderer.enabled = true;
				renderer.sprite = halfway;
			}
			if(PlayerPrefs.GetInt("rivalSpellsParts") == 3){
				renderer.enabled = true;
				renderer.sprite = fully;
			}
		}
		if (is_r){
			if(PlayerPrefs.GetInt("heroItemsParts") == 0){
				renderer.enabled = false;
			}
			if(PlayerPrefs.GetInt("heroItemsParts") == 1 ||PlayerPrefs.GetInt("heroItemsParts") == 2){
				renderer.enabled = true;
				renderer.sprite = halfway;
			}
			if(PlayerPrefs.GetInt("heroItemsParts") == 3){
				renderer.enabled = true;
				renderer.sprite = fully;
			}
		}
		if (is_y){
			if(PlayerPrefs.GetInt("heroSpellsParts") == 0){
				renderer.enabled = false;
			}
			if(PlayerPrefs.GetInt("heroSpellsParts") == 1 || PlayerPrefs.GetInt("heroSpellsParts") == 2){
				renderer.enabled = true;
				renderer.sprite = halfway;
			}
			if(PlayerPrefs.GetInt("heroSpellsParts") == 3){
				renderer.enabled = true;
				renderer.sprite = fully;
			}
		}
		if (is_u){
			if(PlayerPrefs.GetInt("playerItemsParts") == 0){
				renderer.enabled = false;
			}
			if(PlayerPrefs.GetInt("playerItemsParts") == 1 || PlayerPrefs.GetInt("playerItemsParts") == 2){
				renderer.enabled = true;
				renderer.sprite = halfway;
			}
			if(PlayerPrefs.GetInt("playerItemsParts") == 3){
				renderer.enabled = true;
				renderer.sprite = fully;
			}
		}
		if (is_o){
			if(PlayerPrefs.GetInt("playerSpellsParts") == 0){
				renderer.enabled = false;
			}
			if(PlayerPrefs.GetInt("playerSpellsParts") == 1 || PlayerPrefs.GetInt("playerSpellsParts") == 2){
				renderer.enabled = true;
				renderer.sprite = halfway;
			}
			if(PlayerPrefs.GetInt("playerSpellsParts") == 3){
				renderer.enabled = true;
				renderer.sprite = fully;
			}
		}
		if (is_p){
			if(PlayerPrefs.GetInt("optionsParts") == 0){
				renderer.enabled = false;
			}
			if(PlayerPrefs.GetInt("optionsParts") == 1 || PlayerPrefs.GetInt("optionsParts") == 2){
				renderer.enabled = true;
				renderer.sprite = halfway;
			}
			if(PlayerPrefs.GetInt("optionsParts") == 3){
				renderer.enabled = true;
				renderer.sprite = fully;
			}
		}


	}
}
