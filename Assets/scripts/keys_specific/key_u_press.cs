using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_u_press : MonoBehaviour {

	public int this_is, the_other_is;
	// Use this for initialization
	void Start () {
		if((PlayerPrefs.GetInt("playerItemsParts") == this_is) || (PlayerPrefs.GetInt("playerItemsParts") == 3)){
			Destroy(gameObject);
		}

	}


	void OnTriggerEnter2D(Collider2D col){
		if(PlayerPrefs.GetInt("playerItemsParts") == 0){
			PlayerPrefs.SetInt("playerItemsParts", this_is);
		}
		if(PlayerPrefs.GetInt("playerItemsParts") == the_other_is){
			PlayerPrefs.SetInt("playerItemsParts", 3);
		}
	}
	// Update is called once per frame
	void Update () {

	}
}
