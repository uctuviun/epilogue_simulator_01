using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treekeeper : MonoBehaviour {

	public GameObject tree, shaow;

	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt("treeGrown") == 1){
			Instantiate(tree, new Vector2(4.596f, 3.149f), Quaternion.identity);
			Instantiate(shaow, new Vector2(4.596f, 3.149f), Quaternion.identity);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
