using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour {

	Animator animator;
	Rigidbody2D rb2d;
	float speed;
	const int  LDOWN = 1, LUP = 2, RUP = 3, RDOWN = 4, LDZ = 5, LUZ = 6, RUZ = 7, RDZ = 8;
	int _currentAnimationState = 0;

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

		PlayerPrefs.SetFloat("playerX", transform.position.x);
		PlayerPrefs.SetFloat("playerY", transform.position.y);



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

		Vector2 movement = new Vector2(0, 0);

		if (Input.GetKey("k")){
			movement = new Vector2(-2, -1);
			changeState(LDOWN);
		}
		if (Input.GetKey("j")){
			movement = new Vector2(-2, 1);
			changeState(LUP);
		}
		if (Input.GetKey("i")){
			movement = new Vector2(2, 1);
			changeState(RUP);
		}
		if (Input.GetKey("l")){
			movement = new Vector2(2, -1);
			changeState(RDOWN);
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
