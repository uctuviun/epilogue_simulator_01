using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogue_destruct_pillar : MonoBehaviour {

	public int duration;
	AudioSource audiosource;
	public bool p_one, p_two, p_three, p_four, p_five, p_six, p_seven, p_eight,
		p_nine, p_ten, p_eleven, p_twelve, p_thirteen;

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
			if(p_one){
				PlayerPrefs.SetInt("pillarOne", 2);
			}
			Destroy(gameObject);
		}
	}
}	
