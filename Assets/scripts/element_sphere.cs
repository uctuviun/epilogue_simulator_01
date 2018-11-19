using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class element_sphere : MonoBehaviour {

	Animator animator;


	// Use this for initialization
	void Start () {

			animator = GetComponent<Animator>();
			animator.enabled = true;

	}

	// Update is called once per frame
	void Update () {

		if(PlayerPrefs.GetInt("elementOn") == 1){
			animator.SetInteger ("state", 1);
			animator.enabled = true;
		}
		if(PlayerPrefs.GetInt("elementOn") == 2){
			animator.SetInteger ("state", 2);
			animator.enabled = true;
		}
		if(PlayerPrefs.GetInt("elementOn") == 3){
			animator.SetInteger ("state", 3);
			animator.enabled = true;
		}
	}
}
