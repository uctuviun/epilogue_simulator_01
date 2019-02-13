using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class herospecies_evacuate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt("playerTransform") == 1 && PlayerPrefs.GetInt("treeGrown") == 1){
			Destroy(gameObject);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
