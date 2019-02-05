using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piecekiller : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt("minigameOn") == 1){
			Destroy (gameObject);
		}
	}
}
