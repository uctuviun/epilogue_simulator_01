using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishkeeper : MonoBehaviour {

	public GameObject fishes;

	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt("fishesBorn") == 1){
			Instantiate(fishes, new Vector2(0,0), Quaternion.identity);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
