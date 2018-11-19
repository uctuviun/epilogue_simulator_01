using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_o_press : MonoBehaviour {

	public int this_is, the_other_is;
	// Use this for initialization
	void Start () {
		if((PlayerPrefs.GetInt("playerSpellsParts") == this_is) || (PlayerPrefs.GetInt("playerSpellsParts") == 3)){
			Destroy(gameObject);
		}

	}


	void OnTriggerEnter2D(Collider2D col){
		if(PlayerPrefs.GetInt("playerSpellsParts") == 0){
			PlayerPrefs.SetInt("playerSpellsParts", this_is);
		}
		if(PlayerPrefs.GetInt("playerSpellsParts") == the_other_is){
			PlayerPrefs.SetInt("playerSpellsParts", 3);
		}
	}
	// Update is called once per frame
	void Update () {

	}
}
