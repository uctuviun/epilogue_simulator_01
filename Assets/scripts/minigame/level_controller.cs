using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_controller : MonoBehaviour {

	public float threex, threey, twox, twoy, onex, oney, zerox, zeroy, scalex, scaley;
	public GameObject three, two, one, zero;
	int level, nextlevel = 1;

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
		nextlevel = PlayerPrefs.GetInt("minigameLevel") + 1;


	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "piece0" && PlayerPrefs.GetInt("miniLevelSwitch") == 1){
			PlayerPrefs.SetInt("minigameLevel", nextlevel);
			StartCoroutine (Killer());
/*ha, what an idiot (fix directly above):
		if(PlayerPrefs.GetInt("minigameLevel") == 26){
				PlayerPrefs.SetInt("minigameLevel", 27);
				StartCoroutine (Killer());
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 25){
				PlayerPrefs.SetInt("minigameLevel", 26);
				StartCoroutine (Killer());
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 24){
				PlayerPrefs.SetInt("minigameLevel", 25);
				StartCoroutine (Killer());
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 23){
				PlayerPrefs.SetInt("minigameLevel", 24);
				StartCoroutine (Killer());
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 22){
				PlayerPrefs.SetInt("minigameLevel", 23);
				StartCoroutine (Killer());
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 21){
				PlayerPrefs.SetInt("minigameLevel", 22);
				StartCoroutine (Killer());
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 20){
				PlayerPrefs.SetInt("minigameLevel", 21);
				StartCoroutine (Killer());
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 19){
				PlayerPrefs.SetInt("minigameLevel", 20);
				StartCoroutine (Killer());
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 18){
				PlayerPrefs.SetInt("minigameLevel", 19);
				StartCoroutine (Killer());
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 17){
				PlayerPrefs.SetInt("minigameLevel", 18);
				StartCoroutine (Killer());
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 16){
				PlayerPrefs.SetInt("minigameLevel", 17);
				StartCoroutine (Killer());
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 15){
				PlayerPrefs.SetInt("minigameLevel", 16);
				StartCoroutine (Killer());
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 14){
				PlayerPrefs.SetInt("minigameLevel", 15);
				StartCoroutine (Killer());
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 13){
				PlayerPrefs.SetInt("minigameLevel", 14);
				StartCoroutine (Killer());
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 12){
				PlayerPrefs.SetInt("minigameLevel", 13);
				StartCoroutine (Killer());
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 11){
				PlayerPrefs.SetInt("minigameLevel", 12);
				StartCoroutine (Killer());
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 10){
				PlayerPrefs.SetInt("minigameLevel", 11);
				StartCoroutine (Killer());
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 9){
				PlayerPrefs.SetInt("minigameLevel", 10);
				StartCoroutine (Killer());
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 8){
				PlayerPrefs.SetInt("minigameLevel", 9);
				StartCoroutine (Killer());
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 7){
				PlayerPrefs.SetInt("minigameLevel", 8);
				StartCoroutine (Killer());
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 6){
				Debug.Log("huh?");
				PlayerPrefs.SetInt("minigameLevel", 7);
				StartCoroutine (Killer());
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 5){
				PlayerPrefs.SetInt("minigameLevel", 6);
				StartCoroutine (Killer());
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 4){
				Debug.Log("...how?");
				PlayerPrefs.SetInt("minigameLevel", 5);
				StartCoroutine (Killer());
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 3){
				PlayerPrefs.SetInt("minigameLevel", 4);
				StartCoroutine (Killer());
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 2){
				Debug.Log("what now?");
				PlayerPrefs.SetInt("minigameLevel", 3);
				StartCoroutine (Killer());
			}
			if(PlayerPrefs.GetInt("minigameLevel") == 1){
				PlayerPrefs.SetInt("minigameLevel", 2);
				Debug.Log("lv 1 cleared");
				StartCoroutine (Killer());
			}*/
//			PlayerPrefs.SetInt("minigameOn", 1);
//			Destroy (this.gameObject);
		}
		else{
			PlayerPrefs.SetInt("minigameOn", 1);
			Destroy (this.gameObject);
		}
	}

	IEnumerator Killer(){
		Debug.Log("switch off");
		PlayerPrefs.SetInt("miniLevelSwitch", 0);
		PlayerPrefs.SetInt("miniLevelSwitch", 1);
		Debug.Log("switch back on");
		yield return new WaitForSeconds(.01f);
		PlayerPrefs.SetInt("minigameOn", 1);
		Destroy (this.gameObject);
	}
}
