using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class q_menu_destruct : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("q") ||
		(PlayerPrefs.GetInt("playerItemsParts") > 0 && Input.GetKeyDown("u")) ||
		(PlayerPrefs.GetInt("heroItemsParts") > 0 && Input.GetKeyDown("r"))){
				Destroy(gameObject);
			}

	}
}
