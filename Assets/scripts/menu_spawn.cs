using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_spawn : MonoBehaviour {

	public bool pIsOpen = false, oIsOpen = false, eIsOpen = false, yIsOpen = false,
		uIsOpen = false, qIsOpen = false, rIsOpen = false;
	public GameObject p_1, p_2, p_3, o_1, o_2, o_3, e_1, e_2, e_3, y_1, y_2, y_3,
		u_1, u_2, u_3, q_1, q_2, q_3, r_1, r_2, r_3;
	GameObject p1, p2, p3, o1, o2, o3, e1, e2, e3, y1, y2, y3, u1, u2, u3, q1, q2, q3, r1, r2, r3;
	public float duration;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("p") && !pIsOpen && PlayerPrefs.GetInt("optionsParts") == 1){
			p1 = Instantiate(p_1, new Vector2 (-100, -100), Quaternion.identity);
			pIsOpen = true;
//			StartCoroutine(TurnPBackOff());
		}
		if(Input.GetKeyDown("p") && !pIsOpen && PlayerPrefs.GetInt("optionsParts") == 2){
			p2 = Instantiate(p_2, new Vector2 (-100, -200), Quaternion.identity);
			pIsOpen = true;
//			StartCoroutine(TurnPBackOff());
		}
		if(Input.GetKeyDown("p") && !pIsOpen && PlayerPrefs.GetInt("optionsParts") == 3){
			p3 = Instantiate(p_3, new Vector2 (-100, -300), Quaternion.identity);
			pIsOpen = true;
//			StartCoroutine(TurnPBackOff());
		}
		if(Input.GetKeyDown("o") && !oIsOpen && PlayerPrefs.GetInt("playerSpellsParts") == 1){
			o1 = Instantiate(o_1, new Vector2 (-100, -400), Quaternion.identity);
			oIsOpen = true;
//			StartCoroutine(TurnOBackOff());
		}
		if(Input.GetKeyDown("o") && !oIsOpen && PlayerPrefs.GetInt("playerSpellsParts") == 2){
			o2 = Instantiate(o_2, new Vector2 (-100, -500), Quaternion.identity);
			oIsOpen = true;
//			StartCoroutine(TurnOBackOff());
		}
		if(Input.GetKeyDown("o") && !oIsOpen && PlayerPrefs.GetInt("playerSpellsParts") == 3){
			o3 = Instantiate(o_3, new Vector2 (-100, -600), Quaternion.identity);
			oIsOpen = true;
//			StartCoroutine(TurnOBackOff());
		}
		if(Input.GetKeyDown("e") && !eIsOpen && PlayerPrefs.GetInt("rivalSpellsParts") == 1){
			e1 = Instantiate(e_1, new Vector2 (-100, -700), Quaternion.identity);
			eIsOpen = true;
//			StartCoroutine(TurnEBackOff());
		}
		if(Input.GetKeyDown("e") && !eIsOpen && PlayerPrefs.GetInt("rivalSpellsParts") == 2){
			e2 = Instantiate(e_2, new Vector2 (-100, -800), Quaternion.identity);
			eIsOpen = true;
//			StartCoroutine(TurnEBackOff());
		}
		if(Input.GetKeyDown("e") && !eIsOpen && PlayerPrefs.GetInt("rivalSpellsParts") == 3){
			e3 = Instantiate(e_3, new Vector2 (-100, -900), Quaternion.identity);
			eIsOpen = true;
//			StartCoroutine(TurnEBackOff());
		}
		if(Input.GetKeyDown("y") && !yIsOpen && PlayerPrefs.GetInt("heroSpellsParts") == 1){
			y1 = Instantiate(y_1, new Vector2 (-100, -1000), Quaternion.identity);
			yIsOpen = true;
//			StartCoroutine(TurnYBackOff());
		}
		if(Input.GetKeyDown("y") && !yIsOpen && PlayerPrefs.GetInt("heroSpellsParts") == 2){
			y2 = Instantiate(y_2, new Vector2 (-100, -1100), Quaternion.identity);
			yIsOpen = true;
//			StartCoroutine(TurnYBackOff());
		}
		if(Input.GetKeyDown("y") && !yIsOpen && PlayerPrefs.GetInt("heroSpellsParts") == 3){
			y3 = Instantiate(y_3, new Vector2 (-100, -1200), Quaternion.identity);
			yIsOpen = true;
//			StartCoroutine(TurnYBackOff());
		}
		if(Input.GetKeyDown("u") && !uIsOpen && PlayerPrefs.GetInt("playerItemsParts") == 1){
			u1 = Instantiate(u_1, new Vector2 (-100, -1300), Quaternion.identity);
			uIsOpen = true;
	//		StartCoroutine(TurnUBackOff());
		}
		if(Input.GetKeyDown("u") && !uIsOpen && PlayerPrefs.GetInt("playerItemsParts") == 2){
			u2 = Instantiate(u_2, new Vector2 (-100, -1400), Quaternion.identity);
			uIsOpen = true;
//			StartCoroutine(TurnUBackOff());
		}
		if(Input.GetKeyDown("u") && !uIsOpen && PlayerPrefs.GetInt("playerItemsParts") == 3){
			u3 = Instantiate(u_3, new Vector2 (-100, -1500), Quaternion.identity);
			uIsOpen = true;
//			StartCoroutine(TurnUBackOff());
		}
		if(Input.GetKeyDown("q") && !qIsOpen && PlayerPrefs.GetInt("rivalItemsParts") == 1){
			q1 = Instantiate(q_1, new Vector2 (-100, -1600), Quaternion.identity);
			qIsOpen = true;
//			StartCoroutine(TurnQBackOff());
		}
		if(Input.GetKeyDown("q") && !qIsOpen && PlayerPrefs.GetInt("rivalItemsParts") == 2){
			q2 = Instantiate(q_2, new Vector2 (-100, -1700), Quaternion.identity);
			qIsOpen = true;
//			StartCoroutine(TurnQBackOff());
		}
		if(Input.GetKeyDown("q") && !qIsOpen && PlayerPrefs.GetInt("rivalItemsParts") == 3){
			q3 = Instantiate(q_3, new Vector2 (-100, -1800), Quaternion.identity);
			qIsOpen = true;
//			StartCoroutine(TurnQBackOff());
		}
		if(Input.GetKeyDown("r") && !rIsOpen && PlayerPrefs.GetInt("heroItemsParts") == 1){
			r1 = Instantiate(r_1, new Vector2 (-100, -1900), Quaternion.identity);
			rIsOpen = true;
	//		StartCoroutine(TurnRBackOff());
		}
		if(Input.GetKeyDown("r") && !rIsOpen && PlayerPrefs.GetInt("heroItemsParts") == 2){
			r2 = Instantiate(r_2, new Vector2 (-100, -2000), Quaternion.identity);
			rIsOpen = true;
//			StartCoroutine(TurnRBackOff());
		}
		if(Input.GetKeyDown("r") && !rIsOpen && PlayerPrefs.GetInt("heroItemsParts") == 3){
			r3 = Instantiate(r_3, new Vector2 (-100, -2100), Quaternion.identity);
			rIsOpen = true;
//			StartCoroutine(TurnRBackOff());
		}
		if (p1 == null && p2 == null && p3 == null){
			pIsOpen = false;
		}
		if (o1 == null && o2 == null && o3 == null){
			oIsOpen = false;
		}
		if (e1 == null && e2 == null && e3 == null){
			eIsOpen = false;
		}
		if (y1 == null && y2 == null && y3 == null){
			yIsOpen = false;
		}
		if (u1 == null && u2 == null && u3 == null){
			uIsOpen = false;
		}
		if (q1 == null && q2 == null && q3 == null){
			qIsOpen = false;
		}
		if (r1 == null && r2 == null && r3 == null){
			rIsOpen = false;
		}
	}

//(if i were even vaguely decent at coding
//this whole thing would be like a tenth of the length)


/*	IEnumerator TurnPBackOff(){
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
	*/
}
