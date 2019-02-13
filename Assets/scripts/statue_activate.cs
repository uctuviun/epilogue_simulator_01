using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statue_activate : MonoBehaviour {

	public bool inZone = false;
	Animator animator;
	public GameObject evaporate;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt("ancientHeroOver") == 0){
			if(inZone == true && PlayerPrefs.GetInt("playerTransform") == 1 && PlayerPrefs.GetInt("treeGrown") == 1){
				Instantiate(evaporate, transform.position, Quaternion.identity);
				PlayerPrefs.SetInt("orangePlayer", 1);
				PlayerPrefs.SetInt("ancientHeroOver", 1);
			}
			if(inZone == true && PlayerPrefs.GetInt("boneZone") == 1){
				Debug.Log("activate bone");
				PlayerPrefs.SetInt("boneActive", 1);
			}
			if(inZone == true && PlayerPrefs.GetInt("haloZone") == 1){
				Debug.Log("activate halo");
				PlayerPrefs.SetInt("haloActive", 1);
			}
			if(PlayerPrefs.GetInt("boneActive") == 1 && PlayerPrefs.GetInt("haloActive") == 1){
				animator.SetInteger ("state", 0);
				if(PlayerPrefs.GetInt("ancientHeroRelease") == 0){
					PlayerPrefs.SetInt("ancientHeroRelease", 1);
				}
				if(PlayerPrefs.GetInt("ancientHeroRelease") == 1){
					Instantiate(evaporate, transform.position, Quaternion.identity);
					PlayerPrefs.SetInt("ancientHeroOver", 1);
				}
			}
			else if(PlayerPrefs.GetInt("boneActive") == 1 || PlayerPrefs.GetInt("haloActive") == 1){
				animator.SetInteger ("state", 1);
			}
		}
		if(PlayerPrefs.GetInt("ancientHeroOver") == 1){
			animator.SetInteger ("state", 0);
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
}
