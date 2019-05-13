using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour {

	Animator animator;
	Rigidbody2D rb2d;
	float speed;
	const int  LDOWN = 1, LUP = 2, RUP = 3, RDOWN = 4, LDZ = 5, LUZ = 6, RUZ = 7, RDZ = 8;
	int _currentAnimationState = 0;
	public RuntimeAnimatorController released, transformed, orange;


	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator>();
	}



	void changeState(int state){
		if (_currentAnimationState == state)
		return;
		switch(state){
			case LUP:
							animator.SetInteger ("state", LUP);
							break;
			case RDOWN:
					    animator.SetInteger ("state", RDOWN);
					    break;
			case RUP:
							animator.SetInteger ("state", RUP);
							break;
			case LDOWN:
					    animator.SetInteger ("state", LDOWN);
					    break;
			case LDZ:
							animator.SetInteger ("state", LDZ);
							break;
			case LUZ:
							animator.SetInteger ("state", LUZ);
							break;
			case RDZ:
							animator.SetInteger ("state", RDZ);
							break;
			case RUZ:
							animator.SetInteger ("state", RUZ);
							break;
		}
	}


	// Update is called once per frame
	void Update () {

		if(PlayerPrefs.GetInt("releasedMode") == 1){
			animator.runtimeAnimatorController = released;
		}
		else if(PlayerPrefs.GetInt("playerTransform") == 1 && PlayerPrefs.GetInt("orangePlayer") == 0){
			animator.runtimeAnimatorController = transformed;
		}
		else if(PlayerPrefs.GetInt("orangePlayer") == 1){
			animator.runtimeAnimatorController = orange;
		}
		PlayerPrefs.SetFloat("playerX", transform.position.x);
		PlayerPrefs.SetFloat("playerY", transform.position.y);



		if(PlayerPrefs.GetInt("releasedMode") == 1){
			if(PlayerPrefs.GetInt("slowed") == 1){
				speed = 3;
			}
			else{
				speed = 50;
			}
		}
		else if(PlayerPrefs.GetInt("freeze") == 1){
			speed = 0;
		}
		else if(PlayerPrefs.GetInt("gameSpeed") == 1){
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
				speed = 11;
			}
		}
		else if(PlayerPrefs.GetInt("gameSpeed") == 4){
			if(PlayerPrefs.GetInt("slowed") == 1){
				speed = 3;
			}
			else{
				speed = 17;
			}
		}


		Vector2 movement = new Vector2(0, 0);

		if (PlayerPrefs.GetInt("inMotion") == 0 || PlayerPrefs.GetInt("inMotion") == 1){
			if (Input.GetKey("k")){
				movement = new Vector2(-2, -1);
				changeState(LDOWN);
				PlayerPrefs.SetInt("inMotion", 1);
			}
		}
		if (PlayerPrefs.GetInt("inMotion") == 1 && !Input.GetKey("k")){
			PlayerPrefs.SetInt("inMotion", 0);
		}
		if (PlayerPrefs.GetInt("inMotion") == 0 || PlayerPrefs.GetInt("inMotion") == 2){
			if (Input.GetKey("j")){
				movement = new Vector2(-2, 1);
				changeState(LUP);
				PlayerPrefs.SetInt("inMotion", 2);
			}
		}
		if (PlayerPrefs.GetInt("inMotion") == 2 && !Input.GetKey("j")){
			PlayerPrefs.SetInt("inMotion", 0);
		}
		if (PlayerPrefs.GetInt("inMotion") == 0 || PlayerPrefs.GetInt("inMotion") == 3){
			if (Input.GetKey("i")){
				movement = new Vector2(2, 1);
				changeState(RUP);
				PlayerPrefs.SetInt("inMotion", 3);
			}
		}
		if (PlayerPrefs.GetInt("inMotion") == 3 && !Input.GetKey("i")){
			PlayerPrefs.SetInt("inMotion", 0);
		}
		if (PlayerPrefs.GetInt("inMotion") == 0 || PlayerPrefs.GetInt("inMotion") == 4){
			if (Input.GetKey("l")){
				movement = new Vector2(2, -1);
				changeState(RDOWN);
				PlayerPrefs.SetInt("inMotion", 4);
			}
		}
		if (PlayerPrefs.GetInt("inMotion") == 4 && !Input.GetKey("l")){
			PlayerPrefs.SetInt("inMotion", 0);
		}

		if (!Input.anyKey){
			PlayerPrefs.SetInt("inMotion", 0);
		}
		rb2d.AddForce(movement * speed);

		if ((!Input.anyKey) && (animator.GetInteger("state") == LDOWN)){
			changeState(LDZ);
		}
		if ((!Input.anyKey) && (animator.GetInteger("state") == LUP)){
			changeState(LUZ);
		}
		if ((!Input.anyKey) && (animator.GetInteger("state") == RDOWN)){
			changeState(RDZ);
		}
		if ((!Input.anyKey) && (animator.GetInteger("state") == RUP)){
			changeState(RUZ);
		}
	}





}
