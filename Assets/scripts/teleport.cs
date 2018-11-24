using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleport : MonoBehaviour {

	public int sendToWorld, whichPortal;
	Animator animator;
	AudioSource audiosource;
	public GameObject fade;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		audiosource = GetComponent<AudioSource>();

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "player"){
			StartCoroutine(Warping());
			if (PlayerPrefs.GetInt("soundOn") == 1){
							audiosource.enabled = true;
			}
		}
	}

	IEnumerator Warping (){
		PlayerPrefs.SetInt("slowed", 1);
		animator.SetInteger ("state", 1);
		Instantiate(fade, transform.position, Quaternion.identity);
		yield return new WaitForSeconds((this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length) -0.1f);
		Destroy(gameObject);
		PlayerPrefs.SetInt("slowed", 0);
		SceneManager.LoadScene(sendToWorld);
		PlayerPrefs.SetInt("sendTo", whichPortal);
	}


}
