using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogue_destruct_pillar : MonoBehaviour {

	public int duration;
	AudioSource audiosource;
	public bool p_one, p_two, p_three, p_four, p_five, p_six, p_seven, p_eight,
		p_nine, p_ten, p_eleven, p_twelve, p_thirteen;
	public GameObject flashback;

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
			if(p_two){
				PlayerPrefs.SetInt("pillarTwo", 2);
			}
			if(p_three){
				PlayerPrefs.SetInt("pillarThree", 2);
			}
			if(p_four){
				PlayerPrefs.SetInt("pillarFour", 2);
			}
			if(p_five){
				PlayerPrefs.SetInt("pillarFive", 2);
			}
			if(p_six){
				PlayerPrefs.SetInt("pillarSix", 2);
			}
			if(p_seven){
				PlayerPrefs.SetInt("pillarSeven", 2);
			}
			if(p_eight){
				PlayerPrefs.SetInt("pillarEight", 2);
			}
			if(p_nine){
				PlayerPrefs.SetInt("pillarNine", 2);
			}
			if(p_ten){
				PlayerPrefs.SetInt("pillarTen", 2);
			}
			if(p_eleven){
				PlayerPrefs.SetInt("pillarEleven", 2);
			}
			if(p_twelve){
				PlayerPrefs.SetInt("pillarTwelve", 2);
			}
			if(p_thirteen){
				PlayerPrefs.SetInt("pillarThirteen", 2);
			}
			Instantiate(flashback, new Vector2 (-100, -100), Quaternion.identity);
			Destroy(gameObject);
		}
	}
}
