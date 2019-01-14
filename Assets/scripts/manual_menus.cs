using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manual_menus : MonoBehaviour {

	public bool pIsOpen = false, oIsOpen = false, eIsOpen = false, yIsOpen = false,
		uIsOpen = false, qIsOpen = false, rIsOpen = false;
	public GameObject p_1, p_2, p_3, o_1, o_2, o_3, e_1, e_2, e_3, y_1, y_2, y_3,
		u_1, u_2, u_3, q_1, q_2, q_3, r_1, r_2, r_3, avatar;
	public int duration;
	//Rigidbody2D rb2d;
	float speed;

	// Use this for initialization
	void Start () {
	//	rb2d = avatar.GetComponent<Rigidbody2D> ();
	}

	public void Press_P (){
		if(!pIsOpen && PlayerPrefs.GetInt("optionsParts") == 1){
			Instantiate(p_1, new Vector2 (-100, -100), Quaternion.identity);
			pIsOpen = true;
			StartCoroutine(TurnPBackOff());
		}
		if(!pIsOpen && PlayerPrefs.GetInt("optionsParts") == 2){
			Instantiate(p_2, new Vector2 (-100, -100), Quaternion.identity);
			pIsOpen = true;
			StartCoroutine(TurnPBackOff());
		}
		if(!pIsOpen && PlayerPrefs.GetInt("optionsParts") == 3){
			Instantiate(p_3, new Vector2 (-100, -100), Quaternion.identity);
			pIsOpen = true;
			StartCoroutine(TurnPBackOff());
		}
	}

	public void Press_O (){
		if(!oIsOpen && PlayerPrefs.GetInt("playerSpellsParts") == 1){
			Instantiate(o_1, new Vector2 (-100, -100), Quaternion.identity);
			oIsOpen = true;
			StartCoroutine(TurnOBackOff());
		}
		if(!oIsOpen && PlayerPrefs.GetInt("playerSpellsParts") == 2){
			Instantiate(o_2, new Vector2 (-100, -100), Quaternion.identity);
			oIsOpen = true;
			StartCoroutine(TurnOBackOff());
		}
		if(!oIsOpen && PlayerPrefs.GetInt("playerSpellsParts") == 3){
			Instantiate(o_3, new Vector2 (-100, -100), Quaternion.identity);
			oIsOpen = true;
			StartCoroutine(TurnOBackOff());
		}
	}

	public void Press_E (){
		if(!eIsOpen && PlayerPrefs.GetInt("rivalSpellsParts") == 1){
			Instantiate(e_1, new Vector2 (-100, -100), Quaternion.identity);
			eIsOpen = true;
			StartCoroutine(TurnEBackOff());
		}
		if(!eIsOpen && PlayerPrefs.GetInt("rivalSpellsParts") == 2){
			Instantiate(e_2, new Vector2 (-100, -100), Quaternion.identity);
			eIsOpen = true;
			StartCoroutine(TurnEBackOff());
		}
		if(!eIsOpen && PlayerPrefs.GetInt("rivalSpellsParts") == 3){
			Instantiate(e_3, new Vector2 (-100, -100), Quaternion.identity);
			eIsOpen = true;
			StartCoroutine(TurnEBackOff());
		}
	}

	public void Press_Y (){
		if(!yIsOpen && PlayerPrefs.GetInt("heroSpellsParts") == 1){
			Instantiate(y_1, new Vector2 (-100, -100), Quaternion.identity);
			yIsOpen = true;
			StartCoroutine(TurnYBackOff());
		}
		if(!yIsOpen && PlayerPrefs.GetInt("heroSpellsParts") == 2){
			Instantiate(y_2, new Vector2 (-100, -100), Quaternion.identity);
			yIsOpen = true;
			StartCoroutine(TurnYBackOff());
		}
		if(!yIsOpen && PlayerPrefs.GetInt("heroSpellsParts") == 3){
			Instantiate(y_3, new Vector2 (-100, -100), Quaternion.identity);
			yIsOpen = true;
			StartCoroutine(TurnYBackOff());
		}
	}

	public void Press_U (){
		if(!uIsOpen && PlayerPrefs.GetInt("playerItemsParts") == 1){
			Instantiate(u_1, new Vector2 (-100, -100), Quaternion.identity);
			uIsOpen = true;
			StartCoroutine(TurnUBackOff());
		}
		if(!uIsOpen && PlayerPrefs.GetInt("playerItemsParts") == 2){
			Instantiate(u_2, new Vector2 (-100, -100), Quaternion.identity);
			uIsOpen = true;
			StartCoroutine(TurnUBackOff());
		}
		if(!uIsOpen && PlayerPrefs.GetInt("playerItemsParts") == 3){
			Instantiate(u_3, new Vector2 (-100, -100), Quaternion.identity);
			uIsOpen = true;
			StartCoroutine(TurnUBackOff());
		}
	}

	public void Press_Q (){
		if((q_1.activeInHierarchy == false) && (q_2.activeInHierarchy == false) && (q_3.activeInHierarchy == false)){
			if(PlayerPrefs.GetInt("rivalItemsParts") == 1){
				Instantiate(q_1, new Vector2 (-100, -100), Quaternion.identity);
				qIsOpen = true;
//				StartCoroutine(TurnQBackOff());
			}
			if(PlayerPrefs.GetInt("rivalItemsParts") == 2){
				Instantiate(q_2, new Vector2 (-100, -100), Quaternion.identity);
				qIsOpen = true;
//				StartCoroutine(TurnQBackOff());
			}
			if(PlayerPrefs.GetInt("rivalItemsParts") == 3){
				Instantiate(q_3, new Vector2 (-100, -100), Quaternion.identity);
				qIsOpen = true;
//				StartCoroutine(TurnQBackOff());
			}
		}
/*		if(qIsOpen){
			Destroy(q_1ok);
			Destroy(q_2ok);
			Destroy(q_3ok);
			qIsOpen = false;
		}*/
	}

	public void Press_R (){
		if(!rIsOpen && PlayerPrefs.GetInt("heroItemsParts") == 1){
			Instantiate(r_1, new Vector2 (-100, -100), Quaternion.identity);
			rIsOpen = true;
			StartCoroutine(TurnRBackOff());
		}
		if(!rIsOpen && PlayerPrefs.GetInt("heroItemsParts") == 2){
			Instantiate(r_2, new Vector2 (-100, -100), Quaternion.identity);
			rIsOpen = true;
			StartCoroutine(TurnRBackOff());
		}
		if(!rIsOpen && PlayerPrefs.GetInt("heroItemsParts") == 3){
			Instantiate(r_3, new Vector2 (-100, -100), Quaternion.identity);
			rIsOpen = true;
			StartCoroutine(TurnRBackOff());
		}
	}

	public void Press_I (){
		if(PlayerPrefs.GetInt("gameSpeed") == 1){
			speed = 3;
		}
		else if(PlayerPrefs.GetInt("gameSpeed") == 2){
			if(PlayerPrefs.GetInt("slowed") == 1){
				speed = 3;
			}
			else{
				speed = 6;
			}
		}
		else if(PlayerPrefs.GetInt("gameSpeed") == 3){
			if(PlayerPrefs.GetInt("slowed") == 1){
				speed = 3;
			}
			else{
				speed = 9;
			}
		}
		else if(PlayerPrefs.GetInt("gameSpeed") == 4){
			if(PlayerPrefs.GetInt("slowed") == 1){
				speed = 3;
			}
			else{
				speed = 15;
			}
		}

		Vector2 movement = new Vector2(2, 1);
		(avatar.GetComponent<Rigidbody2D> ()).AddForce(movement * speed);
	}

	public void Press_J (){
		if(PlayerPrefs.GetInt("gameSpeed") == 1){
			speed = 3;
		}
		else if(PlayerPrefs.GetInt("gameSpeed") == 2){
			if(PlayerPrefs.GetInt("slowed") == 1){
				speed = 3;
			}
			else{
				speed = 6;
			}
		}
		else if(PlayerPrefs.GetInt("gameSpeed") == 3){
			if(PlayerPrefs.GetInt("slowed") == 1){
				speed = 3;
			}
			else{
				speed = 9;
			}
		}
		else if(PlayerPrefs.GetInt("gameSpeed") == 4){
			if(PlayerPrefs.GetInt("slowed") == 1){
				speed = 3;
			}
			else{
				speed = 15;
			}
		}

		Vector2 movement = new Vector2(-2, 1);
		(avatar.GetComponent<Rigidbody2D> ()).AddForce(movement * speed);
	}

	public void Press_K (){
		if(PlayerPrefs.GetInt("gameSpeed") == 1){
			speed = 3;
		}
		else if(PlayerPrefs.GetInt("gameSpeed") == 2){
			if(PlayerPrefs.GetInt("slowed") == 1){
				speed = 3;
			}
			else{
				speed = 6;
			}
		}
		else if(PlayerPrefs.GetInt("gameSpeed") == 3){
			if(PlayerPrefs.GetInt("slowed") == 1){
				speed = 3;
			}
			else{
				speed = 9;
			}
		}
		else if(PlayerPrefs.GetInt("gameSpeed") == 4){
			if(PlayerPrefs.GetInt("slowed") == 1){
				speed = 3;
			}
			else{
				speed = 15;
			}
		}

		Vector2 movement = new Vector2(-2, -1);
		(avatar.GetComponent<Rigidbody2D> ()).AddForce(movement * speed);
	}

	public void Press_L (){
		if(PlayerPrefs.GetInt("gameSpeed") == 1){
			speed = 3;
		}
		else if(PlayerPrefs.GetInt("gameSpeed") == 2){
			if(PlayerPrefs.GetInt("slowed") == 1){
				speed = 3;
			}
			else{
				speed = 6;
			}
		}
		else if(PlayerPrefs.GetInt("gameSpeed") == 3){
			if(PlayerPrefs.GetInt("slowed") == 1){
				speed = 3;
			}
			else{
				speed = 9;
			}
		}
		else if(PlayerPrefs.GetInt("gameSpeed") == 4){
			if(PlayerPrefs.GetInt("slowed") == 1){
				speed = 3;
			}
			else{
				speed = 15;
			}
		}

		Vector2 movement = new Vector2(2, -1);
		(avatar.GetComponent<Rigidbody2D> ()).AddForce(movement * speed);
	}

	// Update is called once per frame
	void Update () {

	}

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
