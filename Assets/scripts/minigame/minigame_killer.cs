using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigame_killer : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("q") || Input.GetKey("e") || Input.GetKey("r") || Input.GetKey("y")
		|| Input.GetKey("u") || Input.GetKey("o") || Input.GetKey("p") || Input.GetKey("i")
		|| Input.GetKey("j") || Input.GetKey("k") || Input.GetKey("l")){
			Destroy (this.gameObject);
		}
	}
}
