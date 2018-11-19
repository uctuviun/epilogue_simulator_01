using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogue_destruct : MonoBehaviour {

	public int duration;

	// Use this for initialization
	void Start () {
//		Destroy(gameObject, duration);
	}

	// Update is called once per frame
	void Update () 		{
		if(Input.GetKeyDown("space")){
				Destroy(gameObject);
			}
	}

}
