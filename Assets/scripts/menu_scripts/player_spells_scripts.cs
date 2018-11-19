using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_spells_scripts : MonoBehaviour {

	public GameObject player, omne_obelus, cynosure, parhelion, full_threnody,
	ancilla_tone, radius_mar, confiteor;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void Omne_Obelus(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY"));
		Instantiate(omne_obelus, spawnAt, Quaternion.identity);
	}
	public void Cynosure(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY"));
		Instantiate(cynosure, spawnAt, Quaternion.identity);
	}
	public void Parhelion(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY"));
		Instantiate(parhelion, spawnAt, Quaternion.identity);
	}
	public void Full_Threnody(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY"));
		Instantiate(full_threnody, spawnAt, Quaternion.identity);
	}
	public void Ancilla_Tone(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY"));
		Instantiate(ancilla_tone, spawnAt, Quaternion.identity);
	}
	public void Radius_Mar(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY"));
		Instantiate(radius_mar, spawnAt, Quaternion.identity);
	}
	public void Confiteor(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY"));
		Instantiate(confiteor, spawnAt, Quaternion.identity);
	}
}
