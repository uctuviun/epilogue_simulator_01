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
	}


	IEnumerator Sinking (){
		animator.SetInteger ("state", 1);
		yield return new WaitForSeconds((this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length));
		Destroy(gameObject);
	}





}
