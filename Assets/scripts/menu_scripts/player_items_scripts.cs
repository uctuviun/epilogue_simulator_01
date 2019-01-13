using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_items_scripts : MonoBehaviour {

	public GameObject source_token, release_chain, apex_lantern, raincatcher, chasm_log,
	reliquary_halo, omne_card;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void Source_Token(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY") +1.7f);
		Instantiate(source_token, spawnAt, Quaternion.identity);
	}
	public void Release_Chain(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY") +1.7f);
		Instantiate(release_chain, spawnAt, Quaternion.identity);
	}
	public void Apex_Lantern(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY") +1.7f);
		Instantiate(apex_lantern, spawnAt, Quaternion.identity);
	}
	public void Raincatcher(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY") +1.7f);
		Instantiate(raincatcher, spawnAt, Quaternion.identity);
	}
	public void Chasm_Log(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY") +1.7f);
		Instantiate(chasm_log, spawnAt, Quaternion.identity);
	}
	public void Reliquary_Halo(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY") +1.7f);
		Instantiate(reliquary_halo, spawnAt, Quaternion.identity);
	}
	public void Omne_Card(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY") +1.7f);
		Instantiate(omne_card, spawnAt, Quaternion.identity);
	}
}
