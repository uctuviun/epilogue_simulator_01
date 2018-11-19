using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class options_scripts : MonoBehaviour {

	// Use this for initialization

	void Awake(){
		DontDestroyOnLoad(this.gameObject);
	}


	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void Resign(){
		Application.Quit();
	}

	public void Light(){
		if(PlayerPrefs.GetInt("gameLight") == 2){
			PlayerPrefs.SetInt("gameLight", 3);
		}
		else if(PlayerPrefs.GetInt("gameLight") == 1){
			PlayerPrefs.SetInt("gameLight", 2);
		}

		else if(PlayerPrefs.GetInt("gameLight") == 3){
			PlayerPrefs.SetInt("gameLight", 1);
		}
	}

	public void Tone(){
		if(PlayerPrefs.GetInt("backgroundMusic") == 2){
			PlayerPrefs.SetInt("backgroundMusic", 5);
		}
		else if(PlayerPrefs.GetInt("backgroundMusic") == 1){
			PlayerPrefs.SetInt("backgroundMusic", 4);
		}
		else if(PlayerPrefs.GetInt("backgroundMusic") == 3){
			PlayerPrefs.SetInt("backgroundMusic", 0);
		}
		else if(PlayerPrefs.GetInt("backgroundMusic") == 0){
			PlayerPrefs.SetInt("backgroundMusic", 1);
		}
		else if(PlayerPrefs.GetInt("backgroundMusic") == 4){
			PlayerPrefs.SetInt("backgroundMusic", 2);
		}
		else if(PlayerPrefs.GetInt("backgroundMusic") == 5){
			PlayerPrefs.SetInt("backgroundMusic", 3);
		}
		else if(PlayerPrefs.GetInt("backgroundMusic") == 6){
			PlayerPrefs.SetInt("backgroundMusic", 0);
		}
		else if(PlayerPrefs.GetInt("backgroundMusic") == 7){
			PlayerPrefs.SetInt("backgroundMusic", 0);
		}
		else if(PlayerPrefs.GetInt("backgroundMusic") == 8){
			PlayerPrefs.SetInt("backgroundMusic", 0);
		}
	}

	public void Speed(){
		if(PlayerPrefs.GetInt("gameSpeed") == 2){
			PlayerPrefs.SetInt("gameSpeed", 3);
		}
		else if(PlayerPrefs.GetInt("gameSpeed") == 1){
			PlayerPrefs.SetInt("gameSpeed", 2);
		}

		else if(PlayerPrefs.GetInt("gameSpeed") == 3){
			PlayerPrefs.SetInt("gameSpeed", 1);
		}
		else if(PlayerPrefs.GetInt("gameSpeed") == 4){
			PlayerPrefs.SetInt("gameSpeed", 1);
		}
	}

	public void Sound(){
		if(PlayerPrefs.GetInt("soundOn") == 1){
			PlayerPrefs.SetInt("soundOn", 0);
		}
		else if(PlayerPrefs.GetInt("soundOn") == 0){
			PlayerPrefs.SetInt("soundOn", 1);
		}
	}

	public void Tuning(){
		if(PlayerPrefs.GetInt("gameTuning") == 2){
			PlayerPrefs.SetInt("gameTuning", 3);
		}
		else if(PlayerPrefs.GetInt("gameTuning") == 1){
			PlayerPrefs.SetInt("gameTuning", 2);
		}
		else if(PlayerPrefs.GetInt("gameTuning") == 3){
			PlayerPrefs.SetInt("gameTuning", 1);
		}
	}

	public void Restart(){
		SceneManager.LoadScene(0);
	}

}
