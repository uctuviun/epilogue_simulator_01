using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_spawn : MonoBehaviour {

	public bool pIsOpen = false, oIsOpen = false, eIsOpen = false, yIsOpen = false,
		uIsOpen = false, qIsOpen = false, rIsOpen = false;
	public GameObject p_1, p_2, p_3, o_1, o_2, o_3, e_1, e_2, e_3, y_1, y_2, y_3,
		u_1, u_2, u_3, q_1, q_2, q_3, r_1, r_2, r_3;
	public int duration;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("p") && !pIsOpen && PlayerPrefs.GetInt("optionsParts") == 1){
			Instantiate(p_1, new Vector2 (-100, -100), Quaternion.identity);
			pIsOpen = true;
			StartCoroutine(TurnPBackOff());
		}
		if(Input.GetKeyDown("p") && !pIsOpen && PlayerPrefs.GetInt("optionsParts") == 2){
			Instantiate(p_2, new Vector2 (-100, -100), Quaternion.identity);
			pIsOpen = true;
			StartCoroutine(TurnPBackOff());
		}
		if(Input.GetKeyDown("p") && !pIsOpen && PlayerPrefs.GetInt("optionsParts") == 3){
			Instantiate(p_3, new Vector2 (-100, -100), Quaternion.identity);
			pIsOpen = true;
			StartCoroutine(TurnPBackOff());
		}
		if(Input.GetKeyDown("o") && !oIsOpen && PlayerPrefs.GetInt("playerSpellsParts") == 1){
			Instantiate(o_1, new Vector2 (-100, -100), Quaternion.identity);
			oIsOpen = true;
			StartCoroutine(TurnOBackOff());
		}
		if(Input.GetKeyDown("o") && !oIsOpen && PlayerPrefs.GetInt("playerSpellsParts") == 2){
			Instantiate(o_2, new Vector2 (-100, -100), Quaternion.identity);
			oIsOpen = true;
			StartCoroutine(TurnOBackOff());
		}
		if(Input.GetKeyDown("o") && !oIsOpen && PlayerPrefs.GetInt("playerSpellsParts") == 3){
			Instantiate(o_3, new Vector2 (-100, -100), Quaternion.identity);
			oIsOpen = true;
			StartCoroutine(TurnOBackOff());
		}
		if(Input.GetKeyDown("e") && !eIsOpen && PlayerPrefs.GetInt("rivalSpellsParts") == 1){
			Instantiate(e_1, new Vector2 (-100, -100), Quaternion.identity);
			eIsOpen = true;
			StartCoroutine(TurnEBackOff());
		}
		if(Input.GetKeyDown("e") && !eIsOpen && PlayerPrefs.GetInt("rivalSpellsParts") == 2){
			Instantiate(e_2, new Vector2 (-100, -100), Quaternion.identity);
			eIsOpen = true;
			StartCoroutine(TurnEBackOff());
		}
		if(Input.GetKeyDown("e") && !eIsOpen && PlayerPrefs.GetInt("rivalSpellsParts") == 3){
			Instantiate(e_3, new Vector2 (-100, -100), Quaternion.identity);
			eIsOpen = true;
			StartCoroutine(TurnEBackOff());
		}
		if(Input.GetKeyDown("y") && !yIsOpen && PlayerPrefs.GetInt("heroSpellsParts") == 1){
			Instantiate(y_1, new Vector2 (-100, -100), Quaternion.identity);
			yIsOpen = true;
			StartCoroutine(TurnYBackOff());
		}
		if(Input.GetKeyDown("y") && !yIsOpen && PlayerPrefs.GetInt("heroSpellsParts") == 2){
			Instantiate(y_2, new Vector2 (-100, -100), Quaternion.identity);
			yIsOpen = true;
			StartCoroutine(TurnYBackOff());
		}
		if(Input.GetKeyDown("y") && !yIsOpen && PlayerPrefs.GetInt("heroSpellsParts") == 3){
			Instantiate(y_3, new Vector2 (-100, -100), Quaternion.identity);
			yIsOpen = true;
			StartCoroutine(TurnYBackOff());
		}
		if(Input.GetKeyDown("u") && !uIsOpen && PlayerPrefs.GetInt("playerItemsParts") == 1){
			Instantiate(u_1, new Vector2 (-100, -100), Quaternion.identity);
			uIsOpen = true;
			StartCoroutine(TurnUBackOff());
		}
		if(Input.GetKeyDown("u") && !uIsOpen && PlayerPrefs.GetInt("playerItemsParts") == 2){
			Instantiate(u_2, new Vector2 (-100, -100), Quaternion.identity);
			uIsOpen = true;
			StartCoroutine(TurnUBackOff());
		}
		if(Input.GetKeyDown("u") && !uIsOpen && PlayerPrefs.GetInt("playerItemsParts") == 3){
			Instantiate(u_3, new Vector2 (-100, -100), Quaternion.identity);
			uIsOpen = true;
			StartCoroutine(TurnUBackOff());
		}
		if(Input.GetKeyDown("q") && !qIsOpen && PlayerPrefs.GetInt("rivalItemsParts") == 1){
			Instantiate(q_1, new Vector2 (-100, -100), Quaternion.identity);
			qIsOpen = true;
			StartCoroutine(TurnQBackOff());
		}
		if(Input.GetKeyDown("q") && !qIsOpen && PlayerPrefs.GetInt("rivalItemsParts") == 2){
			Instantiate(q_2, new Vector2 (-100, -100), Quaternion.identity);
			qIsOpen = true;
			StartCoroutine(TurnQBackOff());
		}
		if(Input.GetKeyDown("q") && !qIsOpen && PlayerPrefs.GetInt("rivalItemsParts") == 3){
			Instantiate(q_3, new Vector2 (-100, -100), Quaternion.identity);
			qIsOpen = true;
			StartCoroutine(TurnQBackOff());
		}
		if(Input.GetKeyDown("r") && !rIsOpen && PlayerPrefs.GetInt("heroItemsParts") == 1){
			Instantiate(r_1, new Vector2 (-100, -100), Quaternion.identity);
			rIsOpen = true;
			StartCoroutine(TurnRBackOff());
		}
		if(Input.GetKeyDown("r") && !rIsOpen && PlayerPrefs.GetInt("heroItemsParts") == 2){
			Instantiate(r_2, new Vector2 (-100, -100), Quaternion.identity);
			rIsOpen = true;
			StartCoroutine(TurnRBackOff());
		}
		if(Input.GetKeyDown("r") && !rIsOpen && PlayerPrefs.GetInt("heroItemsParts") == 3){
			Instantiate(r_3, new Vector2 (-100, -100), Quaternion.identity);
			rIsOpen = true;
			StartCoroutine(TurnRBackOff());
		}
	}

//(if i were even vaguely decent at coding
//this whole thing would be like a tenth of the length)


	IEnumerator TurnPBackOff(){
		yield return new WaitForSeconds(duration);
		pIsOpen = false;
	}

	IEnumerator TurnOBackOff(){
		yield return new WaitForSeconds(duration);
		oIsOpen = false;
	}

	IEnumerator TurnEBackOff(){
		yield return new WaitForSeconds(duration);
		eIsOpen = false;
	}

	IEnumerator TurnYBackOff(){
		yield return new WaitForSeconds(duration);
		yIsOpen = false;
	}

	IEnumerator TurnUBackOff(){
		yield return new WaitForSeconds(duration);
		uIsOpen = false;
	}

	IEnumerator TurnQBackOff(){
		yield return new WaitForSeconds(duration);
		qIsOpen = false;
	}

	IEnumerator TurnRBackOff(){
		yield return new WaitForSeconds(duration);
		rIsOpen = false;
	}
}
