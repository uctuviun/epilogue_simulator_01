using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rival_items_scripts : MonoBehaviour {

	public GameObject rootpuzzle, chainrelease, alphagene, fortuneteller,
	bridgelog, reliquarybone, nullacard;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void Root_Puzzle(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY") +1.7f);
		Instantiate(rootpuzzle, spawnAt, Quaternion.identity);
	}
	public void Chain_Release(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY") +1.7f);
		Instantiate(chainrelease, spawnAt, Quaternion.identity);
	}
	public void Alpha_Gene(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY") +1.7f);
		Instantiate(alphagene, spawnAt, Quaternion.identity);
	}
	public void Fortuneteller(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY") +1.7f);
		Instantiate(fortuneteller, spawnAt, Quaternion.identity);
	}
	public void Bridge_Log(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY") +1.7f);
		Instantiate(bridgelog, spawnAt, Quaternion.identity);
	}
	public void Reliquary_Bone(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY") +1.7f);
		Instantiate(reliquarybone, spawnAt, Quaternion.identity);
	}
	public void Nulla_Card(){
		Vector2 spawnAt = new Vector2(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("playerY") +1.7f);
		Instantiate(nullacard, spawnAt, Quaternion.identity);
	}
}
