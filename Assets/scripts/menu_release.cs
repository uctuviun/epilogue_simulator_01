using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_release : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt("releasedMode") == 1){
			Destroy(gameObject);
		}
	}
}
