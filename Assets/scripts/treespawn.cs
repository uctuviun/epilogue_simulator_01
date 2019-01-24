using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treespawn : MonoBehaviour {

	public bool inZone = false;
	public GameObject growing, tree, shaow;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(inZone == true && PlayerPrefs.GetInt("seedlingUsed") == 1 &&
		PlayerPrefs.GetInt("pouring") == 1 && PlayerPrefs.GetInt("vesselFull") == 1){
			StartCoroutine(Growth());
			PlayerPrefs.SetInt("vesselFull", 0);
		}
		if(PlayerPrefs.GetInt("treeGrown") == 1){
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "player"){
			inZone = true;
		}
	}

	void OnTriggerExit2D(Collider2D col){
		if(col.gameObject.tag == "player"){
			inZone = false;
		}
	}

	IEnumerator Growth(){
		PlayerPrefs.SetInt("slowed", 1);
		Instantiate(growing, new Vector2(-0.1f, 1.4f), Quaternion.identity);
		yield return new WaitForSeconds(1f);
		PlayerPrefs.SetInt("treeGrown", 1);
		PlayerPrefs.SetInt("slowed", 0);
		Instantiate(tree, new Vector2(4.596f, 3.149f), Quaternion.identity);
		Instantiate(shaow, new Vector2(4.596f, 3.149f), Quaternion.identity);
		Destroy(gameObject);
	}
}
