using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_p_press : MonoBehaviour {

	public int this_is, the_other_is;
	// Use this for initialization
	void Start () {
		if((PlayerPrefs.GetInt("optionsParts") == this_is) || (PlayerPrefs.GetInt("optionsParts") == 3)){
			Destroy(gameObject);
		}

	}


	void OnTriggerEnter2D(Collider2D col){
		if(PlayerPrefs.GetInt("optionsParts") == 0){
			PlayerPrefs.SetInt("optionsParts", this_is);
		}
		if(PlayerPrefs.GetInt("optionsParts") == the_other_is){
			PlayerPrefs.SetInt("optionsParts", 3);
		}
	}
	// Update is called once per frame
	void Update () {

	}
}
