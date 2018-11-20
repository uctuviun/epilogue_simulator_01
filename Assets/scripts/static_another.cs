using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class static_another : MonoBehaviour {

	public bool second, third;
	AudioSource AudioSource;

	// Use this for initialization
	void Start () {
		AudioSource = GetComponent<AudioSource>();

	}

	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetInt("soundOn") == 1){
			if (second == true){
				if (PlayerPrefs.GetInt("gameTuning") < 3){
					AudioSource.enabled = true;

				}
				else {
					AudioSource.enabled = false;
				}
			}
			if (third == true){
				if (PlayerPrefs.GetInt("gameTuning") < 2){
					AudioSource.enabled = true;

				}
				else {
					AudioSource.enabled = false;
				}
			}

		}
		if (PlayerPrefs.GetInt("soundOn") == 0){
			AudioSource.enabled = false;
		}

	}
}
