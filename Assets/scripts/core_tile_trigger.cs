using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class core_tile_trigger : MonoBehaviour {

	public bool black_tile, gray_tile, white_tile;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(black_tile){
			if(PlayerPrefs.GetInt("blackCardUsed") == 1){
				(GetComponent<SpriteRenderer> ()).enabled = true;
				(GetComponent<Animator> ()).enabled = true;
			}
		}
		if(gray_tile){
			if(PlayerPrefs.GetInt("ancientHeroOver") == 1){
				(GetComponent<SpriteRenderer> ()).enabled = true;
				(GetComponent<Animator> ()).enabled = true;
			}
		}
		if(white_tile){
			if(PlayerPrefs.GetInt("whiteCardUsed") == 1){
				(GetComponent<SpriteRenderer> ()).enabled = true;
				(GetComponent<Animator> ()).enabled = true;
			}
		}
	}
}
