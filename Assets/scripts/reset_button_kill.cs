using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset_button_kill : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt("gameOver") == 0){
			Destroy(gameObject);
		}
	}
}
