using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_e_press : MonoBehaviour {

	public int this_is, the_other_is;
	// Use this for initialization
	void Start () {
		if((PlayerPrefs.GetInt("rivalSpellsParts") == this_is) || (PlayerPrefs.GetInt("rivalSpellsParts") == 3)){
			Destroy(gameObject);
		}

	}


	void OnTriggerEnter2D(Collider2D col){
		if(PlayerPrefs.GetInt("rivalSpellsParts") == 0){
			PlayerPrefs.SetInt("rivalSpellsParts", this_is);
		}
		if(PlayerPrefs.GetInt("rivalSpellsParts") == the_other_is){
			PlayerPrefs.SetInt("rivalSpellsParts", 3);
		}
	}
	// Update is called once per frame
	void Update () {

	}
}
