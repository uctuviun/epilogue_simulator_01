using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_canceler : MonoBehaviour {

	AudioSource audiosource;

	// Use this for initialization
	void Start () {
		audiosource = GetComponent<AudioSource>();

	}

	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt("soundOn") == 0){
			audiosource.enabled = false;
		}
	}
}
