using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pillar_converse : MonoBehaviour {

	public bool inZone = false;
	public bool p_one, p_two, p_three, p_four, p_five, p_six, p_seven, p_eight,
		p_nine, p_ten, p_eleven, p_twelve, p_thirteen;
	public GameObject dialogue;

	// Use this for initialization
	void Start () {


	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "player"){
			inZone = true;
		}
	}

	void OnTriggerExit2D(Collider2D col){
		if(col.gameObject.tag == "player"){
			inZone = false;
		}
	}

	// Update is called once per frame
	void Update () {
		if (p_one){
			if(PlayerPrefs.GetInt("pillarOne") == 0){
				if(inZone == true && Input.GetKeyDown("space")){
					PlayerPrefs.SetInt("pillarOne", 1);
					Instantiate(dialogue, new Vector2 (-100, -100), Quaternion.identity);
					PlayerPrefs.SetInt("totalPillars", (PlayerPrefs.GetInt("totalPillars")) + 1);
					Debug.Log(PlayerPrefs.GetInt("totalPillars"));
				}
			}
		}
		if (p_two){
			if(PlayerPrefs.GetInt("pillarTwo") == 0){
				if(inZone == true && Input.GetKeyDown("space")){
					PlayerPrefs.SetInt("pillarTwo", 1);
					Instantiate(dialogue, new Vector2 (-100, -100), Quaternion.identity);
					PlayerPrefs.SetInt("totalPillars", (PlayerPrefs.GetInt("totalPillars")) + 1);
					Debug.Log(PlayerPrefs.GetInt("totalPillars"));
				}
			}
		}
		if (p_three){
			if(PlayerPrefs.GetInt("pillarThree") == 0){
				if(inZone == true && Input.GetKeyDown("space")){
					PlayerPrefs.SetInt("pillarThree", 1);
					Instantiate(dialogue, new Vector2 (-100, -100), Quaternion.identity);
					PlayerPrefs.SetInt("totalPillars", (PlayerPrefs.GetInt("totalPillars")) + 1);
					Debug.Log(PlayerPrefs.GetInt("totalPillars"));
				}
			}
		}
		if (p_four){
			if(PlayerPrefs.GetInt("pillarFour") == 0){
				if(inZone == true && Input.GetKeyDown("space")){
					PlayerPrefs.SetInt("pillarFour", 1);
					Instantiate(dialogue, new Vector2 (-100, -100), Quaternion.identity);
					PlayerPrefs.SetInt("totalPillars", (PlayerPrefs.GetInt("totalPillars")) + 1);
					Debug.Log(PlayerPrefs.GetInt("totalPillars"));
				}
			}
		}
		if (p_five){
			if(PlayerPrefs.GetInt("pillarFive") == 0){
				if(inZone == true && Input.GetKeyDown("space")){
					PlayerPrefs.SetInt("pillarFive", 1);
					Instantiate(dialogue, new Vector2 (-100, -100), Quaternion.identity);
					PlayerPrefs.SetInt("totalPillars", (PlayerPrefs.GetInt("totalPillars")) + 1);
					Debug.Log(PlayerPrefs.GetInt("totalPillars"));
				}
			}
		}
		if (p_six){
			if(PlayerPrefs.GetInt("pillarSix") == 0){
				if(inZone == true && Input.GetKeyDown("space")){
					PlayerPrefs.SetInt("pillarSix", 1);
					Instantiate(dialogue, new Vector2 (-100, -100), Quaternion.identity);
					PlayerPrefs.SetInt("totalPillars", (PlayerPrefs.GetInt("totalPillars")) + 1);
					Debug.Log(PlayerPrefs.GetInt("totalPillars"));
				}
			}
		}
		if (p_seven){
			if(PlayerPrefs.GetInt("pillarSeven") == 0){
				if(inZone == true && Input.GetKeyDown("space")){
					PlayerPrefs.SetInt("pillarSeven", 1);
					Instantiate(dialogue, new Vector2 (-100, -100), Quaternion.identity);
					PlayerPrefs.SetInt("totalPillars", (PlayerPrefs.GetInt("totalPillars")) + 1);
					Debug.Log(PlayerPrefs.GetInt("totalPillars"));
				}
			}
		}
		if (p_eight){
			if(PlayerPrefs.GetInt("pillarEight") == 0){
				if(inZone == true && Input.GetKeyDown("space")){
					PlayerPrefs.SetInt("pillarEight", 1);
					Instantiate(dialogue, new Vector2 (-100, -100), Quaternion.identity);
					PlayerPrefs.SetInt("totalPillars", (PlayerPrefs.GetInt("totalPillars")) + 1);
					Debug.Log(PlayerPrefs.GetInt("totalPillars"));
				}
			}
		}
		if (p_nine){
			if(PlayerPrefs.GetInt("pillarNine") == 0){
				if(inZone == true && Input.GetKeyDown("space")){
					PlayerPrefs.SetInt("pillarNine", 1);
					Instantiate(dialogue, new Vector2 (-100, -100), Quaternion.identity);
					PlayerPrefs.SetInt("totalPillars", (PlayerPrefs.GetInt("totalPillars")) + 1);
					Debug.Log(PlayerPrefs.GetInt("totalPillars"));
				}
			}
		}
		if (p_ten){
			if(PlayerPrefs.GetInt("pillarTen") == 0){
				if(inZone == true && Input.GetKeyDown("space")){
					PlayerPrefs.SetInt("pillarTen", 1);
					Instantiate(dialogue, new Vector2 (-100, -100), Quaternion.identity);
					PlayerPrefs.SetInt("totalPillars", (PlayerPrefs.GetInt("totalPillars")) + 1);
					Debug.Log(PlayerPrefs.GetInt("totalPillars"));
				}
			}
		}
		if (p_eleven){
			if(PlayerPrefs.GetInt("pillarEleven") == 0){
				if(inZone == true && Input.GetKeyDown("space")){
					PlayerPrefs.SetInt("pillarEleven", 1);
					Instantiate(dialogue, new Vector2 (-100, -100), Quaternion.identity);
					PlayerPrefs.SetInt("totalPillars", (PlayerPrefs.GetInt("totalPillars")) + 1);
					Debug.Log(PlayerPrefs.GetInt("totalPillars"));
				}
			}
		}
		if (p_twelve){
			if(PlayerPrefs.GetInt("pillarTwelve") == 0){
				if(inZone == true && Input.GetKeyDown("space")){
					PlayerPrefs.SetInt("pillarTwelve", 1);
					Instantiate(dialogue, new Vector2 (-100, -100), Quaternion.identity);
					PlayerPrefs.SetInt("totalPillars", (PlayerPrefs.GetInt("totalPillars")) + 1);
					Debug.Log(PlayerPrefs.GetInt("totalPillars"));
				}
			}
		}
		if (p_thirteen){
			if(PlayerPrefs.GetInt("pillarThirteen") == 0){
				if(inZone == true && Input.GetKeyDown("space")){
					PlayerPrefs.SetInt("pillarThirteen", 1);
					Instantiate(dialogue, new Vector2 (-100, -100), Quaternion.identity);
					PlayerPrefs.SetInt("totalPillars", (PlayerPrefs.GetInt("totalPillars")) + 1);
					Debug.Log(PlayerPrefs.GetInt("totalPillars"));
				}
			}
		}

	}


}
