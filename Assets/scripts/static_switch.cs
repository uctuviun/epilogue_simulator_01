using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class static_switch : MonoBehaviour {
	public AudioClip static_1, static_2, static_3;
	AudioSource AudioSource;
	private static static_switch instance = null;
	public static static_switch Instance {
	     get { return instance; }
	 }


	void Awake() {
		 if (instance != null && instance != this) {
				 Destroy(this.gameObject);
				 return;
		 } else {
				 instance = this;
		 }
		 DontDestroyOnLoad(this.gameObject);
	 }

	// Use this for initialization
	void Start () {
		AudioSource = GetComponent<AudioSource>();

	}

	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetInt("soundOn") == 1){
			AudioSource.clip = static_3;
			AudioSource.enabled = true;
		}
		if (PlayerPrefs.GetInt("soundOn") == 0){
			AudioSource.enabled = false;
		}



/*		if(PlayerPrefs.GetInt("gameTuning") == 3){
		      AudioSource.clip = static_3;
		      AudioSource.enabled = true;
		    }
		else if(PlayerPrefs.GetInt("gameTuning") == 2){
		      AudioSource.clip = static_2;
		      AudioSource.enabled = true;
		    }
		else if(PlayerPrefs.GetInt("gameTuning") == 1){
		      AudioSource.clip = static_1;
		      AudioSource.enabled = true;
		    }*/

	}
}
