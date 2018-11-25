using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogue_destruct : MonoBehaviour {

	public int duration;
	AudioSource audiosource;

	// Use this for initialization
	void Start () {
		audiosource = GetComponent<AudioSource>();
//		Destroy(gameObject, duration);
	}

	// Update is called once per frame
	void Update () 		{
		if(PlayerPrefs.GetInt("soundOn") == 0){
			audiosource.enabled = false;
		}
		if(Input.GetKeyDown("space")){
				Destroy(gameObject);
			}
	}

}
