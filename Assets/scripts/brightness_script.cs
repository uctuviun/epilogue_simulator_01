using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brightness_script : MonoBehaviour {

	SpriteRenderer myImage;
	public Sprite dark, mid;


	// Use this for initialization
	void Start () {
		myImage = GetComponent<SpriteRenderer>();
	}

	// Update is called once per frame
	void Update () {

		if(PlayerPrefs.GetInt("gameLight") == 1){
			myImage.sprite = dark;
			myImage.enabled = true;
		}
		if(PlayerPrefs.GetInt("gameLight") == 2){
			myImage.sprite = mid;
			myImage.enabled = true;
		}
		if(PlayerPrefs.GetInt("gameLight") == 3){
			myImage.enabled = false;
		}

	}
}
