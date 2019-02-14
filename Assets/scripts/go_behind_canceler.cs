using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go_behind_canceler : MonoBehaviour {

	public bool villager, hero;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if(villager){
			if(PlayerPrefs.GetInt("killedTown") == 1){
				Destroy(gameObject);
			}
		}
		if(hero){
			if(PlayerPrefs.GetInt("killedHero") == 1){
				Destroy(gameObject);
			}
		}		
	}
}
