using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_menu_destruct : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("p")){
				Destroy(gameObject);
			}
	}
}
