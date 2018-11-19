using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class y_menu_destruct : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("y") ||
		(PlayerPrefs.GetInt("playerSpellsParts") > 0 && Input.GetKeyDown("o")) ||
		(PlayerPrefs.GetInt("rivalSpellsParts") > 0 && Input.GetKeyDown("e"))){
				Destroy(gameObject);
			}
	}
}
