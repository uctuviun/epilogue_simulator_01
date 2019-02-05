using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigame_levelspawn : MonoBehaviour {

	public GameObject flash, LvA, LvB, LvC, LvD, LvE, LvF, LvG, LvH, LvI, LvJ, LvK,
	LvL, LvM, LvN, LvO, LvP, LvQ, LvR, LvS, LvT, LvU, LvV, LvW, LvX, LvY, LvZ;

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt("minigameOn", 1);
	}

	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 1){
			Instantiate(flash, transform.position, Quaternion.identity);
			Instantiate(LvA, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 2){
			Instantiate(flash, transform.position, Quaternion.identity);
			Debug.Log("level 2");
			Instantiate(LvB, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 3){
			Instantiate(flash, transform.position, Quaternion.identity);
			Instantiate(LvC, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 4){
			Instantiate(flash, transform.position, Quaternion.identity);
			Instantiate(LvD, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 5){
			Instantiate(flash, transform.position, Quaternion.identity);
			Instantiate(LvE, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 6){
			Instantiate(flash, transform.position, Quaternion.identity);
			Instantiate(LvF, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 7){
			Instantiate(flash, transform.position, Quaternion.identity);
			Instantiate(LvG, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 8){
			Instantiate(flash, transform.position, Quaternion.identity);
			Instantiate(LvH, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 9){
			Instantiate(flash, transform.position, Quaternion.identity);
			Instantiate(LvI, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 10){
			Instantiate(flash, transform.position, Quaternion.identity);
			Instantiate(LvJ, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 11){
			Instantiate(flash, transform.position, Quaternion.identity);
			Instantiate(LvK, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 12){
			Instantiate(flash, transform.position, Quaternion.identity);
			Instantiate(LvL, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 13){
			Instantiate(flash, transform.position, Quaternion.identity);
			Instantiate(LvM, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 14){
			Instantiate(flash, transform.position, Quaternion.identity);
			Instantiate(LvN, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 15){
			Instantiate(flash, transform.position, Quaternion.identity);
			Instantiate(LvO, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 16){
			Instantiate(flash, transform.position, Quaternion.identity);
			Instantiate(LvP, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 17){
			Instantiate(flash, transform.position, Quaternion.identity);
			Instantiate(LvQ, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 18){
			Instantiate(flash, transform.position, Quaternion.identity);
			Instantiate(LvR, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 19){
			Instantiate(flash, transform.position, Quaternion.identity);
			Instantiate(LvS, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 20){
			Instantiate(flash, transform.position, Quaternion.identity);
			Instantiate(LvT, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 21){
			Instantiate(flash, transform.position, Quaternion.identity);
			Instantiate(LvU, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 22){
			Instantiate(flash, transform.position, Quaternion.identity);
			Instantiate(LvV, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 23){
			Instantiate(flash, transform.position, Quaternion.identity);
			Instantiate(LvW, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 24){
			Instantiate(flash, transform.position, Quaternion.identity);
			Instantiate(LvX, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 25){
			Instantiate(flash, transform.position, Quaternion.identity);
			Instantiate(LvY, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 26){
			Instantiate(flash, transform.position, Quaternion.identity);
			Instantiate(LvZ, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}
		if(PlayerPrefs.GetInt("minigameOn") == 1 && PlayerPrefs.GetInt("minigameLevel") == 27){
			Instantiate(flash, transform.position, Quaternion.identity);
			StartCoroutine(TurnBackOff());
		}


	}

	IEnumerator TurnBackOff(){
		yield return new WaitForSeconds(.1f);
		PlayerPrefs.SetInt("minigameOn", 0);
	}
}
