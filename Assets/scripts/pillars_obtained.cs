using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pillars_obtained : MonoBehaviour {

	SpriteRenderer renderer;
	public bool is_p1, is_p2, is_p3, is_p4, is_p5, is_p6, is_p7, is_p8, is_p9, is_p10, is_p11, is_p12, is_p13;
	public Sprite icon;

	// Use this for initialization
	void Start () {
		renderer = GetComponent<SpriteRenderer> ();
	}

	// Update is called once per frame
	void Update () {

		if(is_p1){
			if(PlayerPrefs.GetInt("pillarOne") == 0){
				renderer.enabled = false;
			}
			if(PlayerPrefs.GetInt("pillarOne") > 0){
				renderer.enabled = true;
				renderer.sprite = icon;
			}
		}
		if(is_p2){
			if(PlayerPrefs.GetInt("pillarTwo") == 0){
				renderer.enabled = false;
			}
			if(PlayerPrefs.GetInt("pillarTwo") > 0){
				renderer.enabled = true;
				renderer.sprite = icon;
			}
		}
		if(is_p3){
			if(PlayerPrefs.GetInt("pillarThree") == 0){
				renderer.enabled = false;
			}
			if(PlayerPrefs.GetInt("pillarThree") > 0){
				renderer.enabled = true;
				renderer.sprite = icon;
			}
		}
		if(is_p4){
			if(PlayerPrefs.GetInt("pillarFour") == 0){
				renderer.enabled = false;
			}
			if(PlayerPrefs.GetInt("pillarFour") > 0){
				renderer.enabled = true;
				renderer.sprite = icon;
			}
		}
		if(is_p5){
			if(PlayerPrefs.GetInt("pillarFive") == 0){
				renderer.enabled = false;
			}
			if(PlayerPrefs.GetInt("pillarFive") > 0){
				renderer.enabled = true;
				renderer.sprite = icon;
			}
		}
		if(is_p6){
			if(PlayerPrefs.GetInt("pillarSix") == 0){
				renderer.enabled = false;
			}
			if(PlayerPrefs.GetInt("pillarSix") > 0){
				renderer.enabled = true;
				renderer.sprite = icon;
			}
		}
		if(is_p7){
			if(PlayerPrefs.GetInt("pillarSeven") == 0){
				renderer.enabled = false;
			}
			if(PlayerPrefs.GetInt("pillarSeven") > 0){
				renderer.enabled = true;
				renderer.sprite = icon;
			}
		}
		if(is_p8){
			if(PlayerPrefs.GetInt("pillarEight") == 0){
				renderer.enabled = false;
			}
			if(PlayerPrefs.GetInt("pillarEight") > 0){
				renderer.enabled = true;
				renderer.sprite = icon;
			}
		}
		if(is_p9){
			if(PlayerPrefs.GetInt("pillarNine") == 0){
				renderer.enabled = false;
			}
			if(PlayerPrefs.GetInt("pillarNine") > 0){
				renderer.enabled = true;
				renderer.sprite = icon;
			}
		}
		if(is_p11){
			if(PlayerPrefs.GetInt("pillarTen") == 0){
				renderer.enabled = false;
			}
			if(PlayerPrefs.GetInt("pillarTen") > 0){
				renderer.enabled = true;
				renderer.sprite = icon;
			}
		}
		if(is_p11){
			if(PlayerPrefs.GetInt("pillarEleven") == 0){
				renderer.enabled = false;
			}
			if(PlayerPrefs.GetInt("pillarEleven") > 0){
				renderer.enabled = true;
				renderer.sprite = icon;
			}
		}
		if(is_p12){
			if(PlayerPrefs.GetInt("pillarTwelve") == 0){
				renderer.enabled = false;
			}
			if(PlayerPrefs.GetInt("pillarTwelve") > 0){
				renderer.enabled = true;
				renderer.sprite = icon;
			}
		}
		if(is_p13){
			if(PlayerPrefs.GetInt("pillarThirteen") == 0){
				renderer.enabled = false;
			}
			if(PlayerPrefs.GetInt("pillarThirteen") > 0){
				renderer.enabled = true;
				renderer.sprite = icon;
			}
		}


	}
}
