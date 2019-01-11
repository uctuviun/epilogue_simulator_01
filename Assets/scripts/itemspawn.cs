using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemspawn : MonoBehaviour {

	public bool flatbreads, canteen, panpipes, knife, seedling, rival_vessel, player_vessel;
	AudioSource audiosource;

	// Use this for initialization
	void Start () {
		audiosource = GetComponent<AudioSource>();
		StartCoroutine(Activate());
	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator Activate(){
		if(PlayerPrefs.GetInt("soundOn") == 0){
			audiosource.enabled = false;
		}
		PlayerPrefs.SetInt("menuKill", 1);
		yield return new WaitForSeconds((this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length) -0.1f);
		PlayerPrefs.SetInt("menuKill", 0);
		Destroy(gameObject);
	}
}
