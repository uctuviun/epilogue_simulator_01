using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset_button_call : MonoBehaviour {

	public GameObject reset;

	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt("gameOver") == 1){
			Instantiate(reset, new Vector2 (-200, -200), Quaternion.identity);
		}
	}

	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt("gameOver") == 1 && PlayerPrefs.GetInt("resetWindow") == 0){
			Instantiate(reset, new Vector2 (-200, -200), Quaternion.identity);
			PlayerPrefs.SetInt("resetWindow", 1);
		}
/*		else if(PlayerPrefs.GetInt("gameOver") == 1 && PlayerPrefs.GetInt("resetWindow") == 0){
			Debug.Log("going...");
			Instantiate(reset, new Vector2 (-200, -200), Quaternion.identity);
			PlayerPrefs.SetInt("resetWindow", 1);
		}*/
	}
}
