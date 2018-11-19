using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero_spells_script : MonoBehaviour {

	public GameObject player, recover, heal, thundaga, firaga, oblivion, hope, blizzaga;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void Recover(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY") +.1f);
		Instantiate(recover, spawnAt, Quaternion.identity);
	}

	public void Heal(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX") -.1f, PlayerPrefs.GetFloat("playerY") -1.2f);
		Instantiate(heal, spawnAt, Quaternion.identity);
	}

	public void Thundaga(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX") -.2f, PlayerPrefs.GetFloat("playerY") + .25f);
		Instantiate(thundaga, spawnAt, Quaternion.identity);
	}

	public void Firaga(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY") + 1.2f);
		Instantiate(firaga, spawnAt, Quaternion.identity);
	}

	public void Oblivion(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY"));
		Instantiate(oblivion, spawnAt, Quaternion.identity);
	}
	public void Hope(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY"));
		Instantiate(hope, spawnAt, Quaternion.identity);
	}
	public void Blizzaga(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY") + 1);
		Instantiate(blizzaga, spawnAt, Quaternion.identity);
	}

}
