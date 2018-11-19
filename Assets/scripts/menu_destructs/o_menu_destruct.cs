using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class o_menu_destruct : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("o") ||
		(PlayerPrefs.GetInt("rivalSpellsParts") > 0 && Input.GetKeyDown("e")) ||
		(PlayerPrefs.GetInt("heroSpellsParts") > 0 && Input.GetKeyDown("y"))){
				Destroy(gameObject);
			}
	}
}
