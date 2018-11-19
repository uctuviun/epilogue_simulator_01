using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_q_press : MonoBehaviour {

	public int this_is, the_other_is;
	// Use this for initialization
	void Start () {
		if((PlayerPrefs.GetInt("rivalItemsParts") == this_is) || (PlayerPrefs.GetInt("rivalItemsParts") == 3)){
			Destroy(gameObject);
		}

	}


	void OnTriggerEnter2D(Collider2D col){
		if(PlayerPrefs.GetInt("rivalItemsParts") == 0){
			PlayerPrefs.SetInt("rivalItemsParts", this_is);
		}
		if(PlayerPrefs.GetInt("rivalItemsParts") == the_other_is){
			PlayerPrefs.SetInt("rivalItemsParts", 3);
		}
	}
	// Update is called once per frame
	void Update () {

	}
}
