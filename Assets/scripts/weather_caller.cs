using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class weather_caller : MonoBehaviour {

	Animator animator;

	// Use this for initialization
	void Start () {



	}

	// Update is called once per frame
	void Update () {

		Scene currentScene = SceneManager.GetActiveScene();
		string sceneName = currentScene.name;
		animator = GetComponent<Animator>();
		animator.enabled = false;

		if (sceneName == "world10(stairsmoss)" && PlayerPrefs.GetInt("elementOn") == 1){
			animator.SetInteger ("state", 1);
			animator.enabled = true;
		}
		if (sceneName == "world10(stairsmoss)" && PlayerPrefs.GetInt("elementOn") == 2){
			animator.SetInteger ("state", 2);
			animator.enabled = true;
		}
		if (sceneName == "world10(stairsmoss)" && PlayerPrefs.GetInt("elementOn") == 3){
			animator.SetInteger ("state", 3);
			animator.enabled = true;
		}
		if (sceneName != "world10(stairsmoss)"){
			animator.enabled = false;
		}

	}
}
