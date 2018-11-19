using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_y_press : MonoBehaviour {

	public int this_is, the_other_is;
	// Use this for initialization
	void Start () {
		if((PlayerPrefs.GetInt("heroSpellsParts") == this_is) || (PlayerPrefs.GetInt("heroSpellsParts") == 3)){
			Destroy(gameObject);
		}

	}


	void OnTriggerEnter2D(Collider2D col){
		if(PlayerPrefs.GetInt("heroSpellsParts") == 0){
			PlayerPrefs.SetInt("heroSpellsParts", this_is);
		}
		if(PlayerPrefs.GetInt("heroSpellsParts") == the_other_is){
			PlayerPrefs.SetInt("heroSpellsParts", 3);
		}
	}
	// Update is called once per frame
	void Update () {

	}
}
