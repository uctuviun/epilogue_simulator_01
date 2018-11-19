using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportspawn : MonoBehaviour {

	public GameObject player, bgm;
	public float opt1x, opt1y, opt2x, opt2y, opt3x, opt3y;

	// Use this for initialization
	void Start () {
		Instantiate(bgm, new Vector2(opt1x, opt1y), Quaternion.identity);
		if(PlayerPrefs.GetInt("sendTo") == 1){
			Instantiate(player, new Vector2(opt1x, opt1y), Quaternion.identity);
		}
		if(PlayerPrefs.GetInt("sendTo") == 2){
			Instantiate(player, new Vector2(opt2x, opt2y), Quaternion.identity);
		}
		if(PlayerPrefs.GetInt("sendTo") == 3){
			Instantiate(player, new Vector2(opt3x, opt3y), Quaternion.identity);
		}

	}

	// Update is called once per frame
	void Update () {

	}
}
