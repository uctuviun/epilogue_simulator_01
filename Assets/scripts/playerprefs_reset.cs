using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerprefs_reset : MonoBehaviour {

	// Use this for initialization
	void Start () {

		PlayerPrefs.SetInt("sendTo", 1);
		PlayerPrefs.SetInt("optionsParts", 0);
		PlayerPrefs.SetInt("playerItemsParts", 0);
		PlayerPrefs.SetInt("playerSpellsParts", 0);
		PlayerPrefs.SetInt("rivalItemsParts", 0);
		PlayerPrefs.SetInt("rivalSpellsParts", 0);
		PlayerPrefs.SetInt("heroItemsParts", 0);
		PlayerPrefs.SetInt("heroSpellsParts", 0);
		PlayerPrefs.SetInt("talkedToRival", 0);
		PlayerPrefs.SetInt("talkedToHero", 0);
		PlayerPrefs.SetInt("backgroundMusic", 0);
		PlayerPrefs.SetInt("gameSpeed", 2);
		PlayerPrefs.SetInt("gameTuning", 3);
		PlayerPrefs.SetInt("gameLight", 3);
		PlayerPrefs.SetInt("soundOn", 1);
		PlayerPrefs.SetInt("slowed", 0);
		PlayerPrefs.SetInt("killMode", 0);
		PlayerPrefs.SetInt("killedTown", 0);
		PlayerPrefs.SetInt("killedHero", 0);
		PlayerPrefs.SetInt("elementMode", 0);
		//elementMode: 1 = fire, 2 = ice, 3 = thunder
		PlayerPrefs.SetInt("elementOn", 0);

	}

	// Update is called once per frame
	void Update () {

	}
}
