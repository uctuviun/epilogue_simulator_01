using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spellspawn : MonoBehaviour {


	public bool null_effulgence, omne_obelus, panacea, recover, cynosure, sepulchre,
	parhelion, farrago_ring, full_threnody, ancilla_tone, harbinger_tone, radius_mar,
	vituperate, heal, thundaga, firaga, oblivion, hope, blizzaga, confiteor, tribunal;
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
		if(radius_mar == true || vituperate == true){
			PlayerPrefs.SetInt("killMode", 1);
			Debug.Log("KILLMODE");
		}
		if(full_threnody == true || ancilla_tone == true || harbinger_tone == true){
			PlayerPrefs.SetInt("backgroundMusic", 0);
		}
		if(thundaga == true){
			PlayerPrefs.SetInt("elementMode", 3);
		}
		if(firaga == true){
			PlayerPrefs.SetInt("elementMode", 1);
		}
		if(blizzaga == true){
			PlayerPrefs.SetInt("elementMode", 2);
		}
		yield return new WaitForSeconds((this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length) -0.1f);
		if(null_effulgence == true){
			PlayerPrefs.SetInt("gameLight", 1);
		}
		if(omne_obelus == true){
			PlayerPrefs.SetInt("gameSpeed", 1);
		}
		if(panacea == true){
			PlayerPrefs.SetInt("gameSpeed", 3);
			PlayerPrefs.SetInt("gameLight", 3);
			PlayerPrefs.SetInt("gameTuning", 3);
		}
		if(cynosure == true){
			PlayerPrefs.SetInt("backgroundMusic", 0);
		}
		if(sepulchre == true){
			PlayerPrefs.SetInt("gameLight", 1);
			PlayerPrefs.SetInt("gameSpeed", 1);
		}
		if(parhelion == true){
			PlayerPrefs.SetInt("gameLight", 2);
			PlayerPrefs.SetInt("gameTuning", 2);
		}
		if(farrago_ring == true){
			PlayerPrefs.SetInt("gameTuning", 1);
		}
		if(full_threnody == true){
			PlayerPrefs.SetInt("backgroundMusic", 6);
		}
		if(ancilla_tone == true){
			PlayerPrefs.SetInt("backgroundMusic", 7);
		}
		if(harbinger_tone == true){
			PlayerPrefs.SetInt("backgroundMusic", 8);
		}
		if(radius_mar == true || vituperate == true){
			PlayerPrefs.SetInt("killMode", 0);
		}
		if(thundaga == true || firaga == true || blizzaga == true){
			PlayerPrefs.SetInt("elementMode", 0);
		}
		if(oblivion == true){
			PlayerPrefs.SetInt("optionsParts", 0);
			PlayerPrefs.SetInt("playerItemsParts", 0);
			PlayerPrefs.SetInt("playerSpellsParts", 0);
			PlayerPrefs.SetInt("rivalItemsParts", 0);
			PlayerPrefs.SetInt("rivalSpellsParts", 0);
			PlayerPrefs.SetInt("heroItemsParts", 0);
			PlayerPrefs.SetInt("heroSpellsParts", 0);
			PlayerPrefs.SetInt("pillarOne", 0);
			PlayerPrefs.SetInt("pillarTwo", 0);
			PlayerPrefs.SetInt("pillarThree", 0);
			PlayerPrefs.SetInt("pillarFour", 0);
			PlayerPrefs.SetInt("pillarFive", 0);
			PlayerPrefs.SetInt("pillarSix", 0);
			PlayerPrefs.SetInt("pillarSeven", 0);
			PlayerPrefs.SetInt("pillarEight", 0);
			PlayerPrefs.SetInt("pillarNine", 0);
			PlayerPrefs.SetInt("pillarTen", 0);
			PlayerPrefs.SetInt("pillarEleven", 0);
			PlayerPrefs.SetInt("pillarTwelve", 0);
			PlayerPrefs.SetInt("pillarThirteen", 0);
		}
		if(hope == true){
			PlayerPrefs.SetInt("gameSpeed", 4);
		}
		PlayerPrefs.SetInt("menuKill", 0);
		Destroy(gameObject);
	}
}
