using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remembered_things : MonoBehaviour {

	public int phase;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt("totalPillars") < phase){
			(GetComponent<SpriteRenderer> ()).enabled = false;
		}
	}
}
