using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class r_menu_destruct : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("r") ||
		(PlayerPrefs.GetInt("playerItemsParts") > 0 && Input.GetKeyDown("u")) ||
		(PlayerPrefs.GetInt("rivalItemsParts") > 0 && Input.GetKeyDown("q"))){
				Destroy(gameObject);
			}

	}
}
