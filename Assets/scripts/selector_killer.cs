using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selector_killer : MonoBehaviour {

	public bool p_one, p_two, p_three, p_four, p_five, p_six, p_seven, p_eight,
		p_nine, p_ten, p_eleven, p_twelve, p_thirteen, villager, hero;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(p_one){
			if(PlayerPrefs.GetInt("pillarOne") > 0){
				Destroy(gameObject);
			}
		}
		if(p_two){
			if(PlayerPrefs.GetInt("pillarTwo") > 0){
				Destroy(gameObject);
			}
		}
		if(p_three){
			if(PlayerPrefs.GetInt("pillarThree") > 0){
				Destroy(gameObject);
			}
		}
		if(p_four){
			if(PlayerPrefs.GetInt("pillarFour") > 0){
				Destroy(gameObject);
			}
		}
		if(p_five){
			if(PlayerPrefs.GetInt("pillarFive") > 0){
				Destroy(gameObject);
			}
		}
		if(p_six){
			if(PlayerPrefs.GetInt("pillarSix") > 0){
				Destroy(gameObject);
			}
		}
		if(p_seven){
			if(PlayerPrefs.GetInt("pillarSeven") > 0){
				Destroy(gameObject);
			}
		}
		if(p_eight){
			if(PlayerPrefs.GetInt("pillarEight") > 0){
				Destroy(gameObject);
			}
		}
		if(p_nine){
			if(PlayerPrefs.GetInt("pillarNine") > 0){
				Destroy(gameObject);
			}
		}
		if(p_ten){
			if(PlayerPrefs.GetInt("pillarTen") > 0){
				Destroy(gameObject);
			}
		}
		if(p_eleven){
			if(PlayerPrefs.GetInt("pillarEleven") > 0){
				Destroy(gameObject);
			}
		}
		if(p_twelve){
			if(PlayerPrefs.GetInt("pillarTwelve") > 0){
				Destroy(gameObject);
			}
		}
		if(p_thirteen){
			if(PlayerPrefs.GetInt("pillarThirteen") > 0){
				Destroy(gameObject);
			}
		}
		if(villager){
			if(PlayerPrefs.GetInt("killedTown") > 0){
				Destroy(gameObject);
			}
		}
		if(hero){
			if(PlayerPrefs.GetInt("killedHero") > 0){
				Destroy(gameObject);
			}
		}

	}
}
