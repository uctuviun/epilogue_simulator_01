using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_closer : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetInt("menuKill") == 1){
			Destroy (this.gameObject);
		}

	}
}
