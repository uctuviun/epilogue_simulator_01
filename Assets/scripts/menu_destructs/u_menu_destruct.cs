using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class u_menu_destruct : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("u") ||
		(PlayerPrefs.GetInt("rivalItemsParts") > 0 && Input.GetKeyDown("q")) ||
		(PlayerPrefs.GetInt("heroItemsParts") > 0 && Input.GetKeyDown("r"))){
				Destroy(gameObject);
			}

	}
}
