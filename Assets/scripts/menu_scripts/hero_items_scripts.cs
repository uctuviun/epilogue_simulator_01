using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero_items_scripts : MonoBehaviour {

	public GameObject flatbreads, canteen, panpipes, knife, seedling, rival_vessel, player_vessel;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void Flatbreads(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY") +1.7f);
		Instantiate(flatbreads, spawnAt, Quaternion.identity);
	}
	public void Canteen(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY") +1.7f);
		Instantiate(canteen, spawnAt, Quaternion.identity);
	}
	public void Panpipes(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY") +1.7f);
		Instantiate(panpipes, spawnAt, Quaternion.identity);
	}
	public void Knife(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY") +1.7f);
		Instantiate(knife, spawnAt, Quaternion.identity);
	}
	public void Seedling(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY") +1.7f);
		Instantiate(seedling, spawnAt, Quaternion.identity);
	}
	public void Rival_vessel(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY") +1.7f);
		Instantiate(rival_vessel, spawnAt, Quaternion.identity);
	}
	public void Player_vessel(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY") +1.7f);
		Instantiate(player_vessel, spawnAt, Quaternion.identity);
	}
}
