using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_controller : MonoBehaviour {

	public float threex, threey, twox, twoy, onex, oney, zerox, zeroy, scalex, scaley;
	public GameObject three, two, one, zero;
	int level;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt("miniSpawnLevel") == 1){
			Instantiate(three, new Vector3 (transform.position.x, transform.position.y)
			+ new Vector3(threex * scalex, threey * scaley, -20), Quaternion.identity);
			PlayerPrefs.SetInt("miniSpawnLevel", 0);
		}
		if (PlayerPrefs.GetInt("miniSpawnLevel") == 2){
			Instantiate(two, new Vector3 (transform.position.x, transform.position.y)
			+ new Vector3(twox * scalex, twoy * scaley, -20), Quaternion.identity);
			PlayerPrefs.SetInt("miniSpawnLevel", 0);
		}
		if (PlayerPrefs.GetInt("miniSpawnLevel") == 3){
			Instantiate(one, new Vector3 (transform.position.x, transform.position.y)
			+ new Vector3(onex * scalex, oney * scaley, -20), Quaternion.identity);
			PlayerPrefs.SetInt("miniSpawnLevel", 0);
		}
		if (PlayerPrefs.GetInt("miniSpawnLevel") == 4){
			Instantiate(zero, new Vector3 (transform.position.x, transform.position.y)
			+ new Vector3(zerox * scalex, zeroy * scaley, -20), Quaternion.identity);
			PlayerPrefs.SetInt("miniSpawnLevel", 0);
		}

	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "piece0"){
			if(PlayerPrefs.GetInt("minigameLevel") == 1){
				PlayerPrefs.SetInt("minigameLevel", 2);
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 2){
				PlayerPrefs.SetInt("minigameLevel", 3);
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 3){
				PlayerPrefs.SetInt("minigameLevel", 4);
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 4){
				PlayerPrefs.SetInt("minigameLevel", 5);
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 5){
				PlayerPrefs.SetInt("minigameLevel", 6);
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 6){
				PlayerPrefs.SetInt("minigameLevel", 7);
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 7){
				PlayerPrefs.SetInt("minigameLevel", 8);
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 8){
				PlayerPrefs.SetInt("minigameLevel", 9);
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 9){
				PlayerPrefs.SetInt("minigameLevel", 10);
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 10){
				PlayerPrefs.SetInt("minigameLevel", 11);
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 11){
				PlayerPrefs.SetInt("minigameLevel", 12);
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 12){
				PlayerPrefs.SetInt("minigameLevel", 13);
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 13){
				PlayerPrefs.SetInt("minigameLevel", 14);
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 14){
				PlayerPrefs.SetInt("minigameLevel", 15);
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 15){
				PlayerPrefs.SetInt("minigameLevel", 16);
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 16){
				PlayerPrefs.SetInt("minigameLevel", 17);
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 17){
				PlayerPrefs.SetInt("minigameLevel", 18);
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 18){
				PlayerPrefs.SetInt("minigameLevel", 19);
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 19){
				PlayerPrefs.SetInt("minigameLevel", 20);
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 20){
				PlayerPrefs.SetInt("minigameLevel", 21);
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 21){
				PlayerPrefs.SetInt("minigameLevel", 22);
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 22){
				PlayerPrefs.SetInt("minigameLevel", 23);
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 23){
				PlayerPrefs.SetInt("minigameLevel", 24);
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 24){
				PlayerPrefs.SetInt("minigameLevel", 25);
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 25){
				PlayerPrefs.SetInt("minigameLevel", 26);
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 26){
				PlayerPrefs.SetInt("minigameLevel", 27);
			}
			PlayerPrefs.SetInt("minigameOn", 1);
			Destroy (this.gameObject);
		}
		else{
			PlayerPrefs.SetInt("minigameOn", 1);
			Destroy (this.gameObject);
		}
	}
}
