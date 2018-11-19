using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rival_spells_scripts : MonoBehaviour {

	public GameObject player, null_effulgence, panacea, sepulchre, farrago_ring,
	harbinger_tone, vituperate, tribunal;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void Null_Effulgence(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY"));
		Instantiate(null_effulgence, spawnAt, Quaternion.identity);
	}

	public void Panacea(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY"));
		Instantiate(panacea, spawnAt, Quaternion.identity);
	}

	public void Sepulchre(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY"));
		Instantiate(sepulchre, spawnAt, Quaternion.identity);
	}

	public void Farrago_Ring(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY"));
		Instantiate(farrago_ring, spawnAt, Quaternion.identity);
	}
	public void Harbinger_Tone(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY") - 1);
		Instantiate(harbinger_tone, spawnAt, Quaternion.identity);
	}
	public void Vituperate(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY"));
		Instantiate(vituperate, spawnAt, Quaternion.identity);
	}
	public void Tribunal(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY"));
		Instantiate(tribunal, spawnAt, Quaternion.identity);
	}
}
