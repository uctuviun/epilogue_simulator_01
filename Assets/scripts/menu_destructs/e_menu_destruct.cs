using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class e_menu_destruct : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("e") ||
		(PlayerPrefs.GetInt("playerSpellsParts") > 0 && Input.GetKeyDown("o")) ||
		(PlayerPrefs.GetInt("heroSpellsParts") > 0 && Input.GetKeyDown("y"))){
				Destroy(gameObject);
			}
	}
}
