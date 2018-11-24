using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_press : MonoBehaviour {

	Animator animator;
	AudioSource audiosource;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		audiosource = GetComponent<AudioSource>();

	}

	void OnTriggerEnter2D(Collider2D col){
//		if(col.gameObject.tag == "player"){
			animator.SetInteger ("state", 1);
			if (PlayerPrefs.GetInt("soundOn") == 1){
							audiosource.enabled = true;
			}
//			Destroy (gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
				Destroy (this.gameObject, 0.9f);
//		}
	}




	// Update is called once per frame
	void Update () {

	}
}
