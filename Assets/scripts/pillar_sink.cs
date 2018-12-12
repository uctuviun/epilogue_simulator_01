using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pillar_sink : MonoBehaviour {

	Animator animator;
	public bool p_one, p_two, p_three, p_four, p_five, p_six, p_seven, p_eight,
		p_nine, p_ten, p_eleven, p_twelve, p_thirteen;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
		if(p_one){
			if(PlayerPrefs.GetInt("pillarOne") == 1){
				StartCoroutine(Sinking());
			}
			if(PlayerPrefs.GetInt("pillarOne") == 2){
				Destroy(gameObject);
			}
		}
		if(p_two){
			if(PlayerPrefs.GetInt("pillarTwo") == 1){
				StartCoroutine(Sinking());
			}
			if(PlayerPrefs.GetInt("pillarTwo") == 2){
				Destroy(gameObject);
			}
		}
		if(p_three){
			if(PlayerPrefs.GetInt("pillarThree") == 1){
				StartCoroutine(Sinking());
			}
			if(PlayerPrefs.GetInt("pillarThree") == 2){
				Destroy(gameObject);
			}
		}
		if(p_four){
			if(PlayerPrefs.GetInt("pillarFour") == 1){
				StartCoroutine(Sinking());
			}
			if(PlayerPrefs.GetInt("pillarFour") == 2){
				Destroy(gameObject);
			}
		}
		if(p_five){
			if(PlayerPrefs.GetInt("pillarFive") == 1){
				StartCoroutine(Sinking());
			}
			if(PlayerPrefs.GetInt("pillarFive") == 2){
				Destroy(gameObject);
			}
		}
		if(p_six){
			if(PlayerPrefs.GetInt("pillarSix") == 1){
				StartCoroutine(Sinking());
			}
			if(PlayerPrefs.GetInt("pillarSix") == 2){
				Destroy(gameObject);
			}
		}
		if(p_seven){
			if(PlayerPrefs.GetInt("pillarSeven") == 1){
				StartCoroutine(Sinking());
			}
			if(PlayerPrefs.GetInt("pillarSeven") == 2){
				Destroy(gameObject);
			}
		}
		if(p_eight){
			if(PlayerPrefs.GetInt("pillarEight") == 1){
				StartCoroutine(Sinking());
			}
			if(PlayerPrefs.GetInt("pillarEight") == 2){
				Destroy(gameObject);
			}
		}
		if(p_nine){
			if(PlayerPrefs.GetInt("pillarNine") == 1){
				StartCoroutine(Sinking());
			}
			if(PlayerPrefs.GetInt("pillarNine") == 2){
				Destroy(gameObject);
			}
		}
		if(p_ten){
			if(PlayerPrefs.GetInt("pillarTen") == 1){
				StartCoroutine(Sinking());
			}
			if(PlayerPrefs.GetInt("pillarTen") == 2){
				Destroy(gameObject);
			}
		}
		if(p_eleven){
			if(PlayerPrefs.GetInt("pillarEleven") == 1){
				StartCoroutine(Sinking());
			}
			if(PlayerPrefs.GetInt("pillarEleven") == 2){
				Destroy(gameObject);
			}
		}
		if(p_twelve){
			if(PlayerPrefs.GetInt("pillarTwelve") == 1){
				StartCoroutine(Sinking());
			}
			if(PlayerPrefs.GetInt("pillarTwelve") == 2){
				Destroy(gameObject);
			}
		}
		if(p_thirteen){
			if(PlayerPrefs.GetInt("pillarThirteen") == 1){
				StartCoroutine(Sinking());
			}
			if(PlayerPrefs.GetInt("pillarThirteen") == 2){
				Destroy(gameObject);
			}
		}
	}


	IEnumerator Sinking (){
		animator.SetInteger ("state", 1);
		yield return new WaitForSeconds((this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length ));
		Destroy(gameObject);
	}





}
