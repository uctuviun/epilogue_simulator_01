using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_r_press : MonoBehaviour {

	public int this_is, the_other_is;
	// Use this for initialization
	void Start () {
		if((PlayerPrefs.GetInt("heroItemsParts") == this_is) || (PlayerPrefs.GetInt("heroItemsParts") == 3)){
			Destroy(gameObject);
		}

	}


	void OnTriggerEnter2D(Collider2D col){
		if(PlayerPrefs.GetInt("heroItemsParts") == 0){
			PlayerPrefs.SetInt("heroItemsParts", this_is);
		}
		if(PlayerPrefs.GetInt("heroItemsParts") == the_other_is){
			PlayerPrefs.SetInt("heroItemsParts", 3);
		}
	}
	// Update is called once per frame
	void Update () {

	}
}
