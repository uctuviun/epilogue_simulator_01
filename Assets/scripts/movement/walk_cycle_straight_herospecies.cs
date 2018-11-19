using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk_cycle_straight_herospecies : MonoBehaviour {

	ConstantForce2D cf2d;
	Animator animator;
	Rigidbody2D rb2d;
	SpriteRenderer SpriteRenderer;
	CapsuleCollider2D capcoll;
	public float speed, time;
	const int  LDOWN = 1, LUP = 2, RUP = 3, RDOWN = 4, LDZ = 5, LUZ = 6, RUZ = 7, RDZ = 8;
	int _currentAnimationState = 0;
	bool pacing = true;
	public Sprite blood;

	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt("killedTown") == 0){
			cf2d = GetComponent<ConstantForce2D> ();
			rb2d = GetComponent<Rigidbody2D> ();
			animator = GetComponent<Animator>();
			SpriteRenderer = GetComponent<SpriteRenderer>();
			capcoll = GetComponent<CapsuleCollider2D>();
			changeState(LDZ);
			StartCoroutine(Pacing());
		}
		if(PlayerPrefs.GetInt("killedTown") == 1){
			animator = GetComponent<Animator>();
			SpriteRenderer = GetComponent<SpriteRenderer> ();
			capcoll = GetComponent<CapsuleCollider2D>();
			SpriteRenderer.sprite = blood;
			capcoll.enabled = false;
			animator.enabled = false;
		}
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


	IEnumerator Pacing(){
		while(pacing == true){
			changeState(RDOWN);
			cf2d.force = new Vector2(1, -1);
			yield return new WaitForSeconds(time);
			if(pacing == false){
				break;
			}
			changeState(LUP);
			cf2d.force = new Vector2(-1, 1);
			yield return new WaitForSeconds(time);
			if(pacing == false){
				break;
			}
		}

	}

	IEnumerator Exploding(){
		animator.enabled = true;
		animator.SetInteger ("state", 9);
		yield return new WaitForSeconds((this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length) -0.1f);
		PlayerPrefs.SetInt("killMode", 0);
		PlayerPrefs.SetInt("killedTown", 1);
	}

	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt("killMode") == 1 && PlayerPrefs.GetInt("killedTown") == 0){
			StartCoroutine(Exploding());
		}
		if(PlayerPrefs.GetInt("killedTown") == 1){
			rb2d.velocity = Vector2.zero;
			SpriteRenderer = GetComponent<SpriteRenderer> ();
			SpriteRenderer.sprite = blood;
			capcoll.enabled = false;
			animator.enabled = false;
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if(PlayerPrefs.GetInt("killedTown") == 0){
			if(col.gameObject.tag == "player"){
				pacing = false;
				rb2d.velocity = Vector2.zero;
				rb2d.bodyType = RigidbodyType2D.Kinematic;
				if(animator.GetInteger ("state") == LDOWN){
					changeState(LDZ);
					}
				if(animator.GetInteger ("state") == LUP){
					changeState(LUZ);
					}
				if(animator.GetInteger ("state") == RDOWN){
					changeState(RDZ);
					}
				if(animator.GetInteger ("state") == RUP){
					changeState(RUZ);
					}
			}
		}
	}

	void OnTriggerExit2D(Collider2D col){
		if(PlayerPrefs.GetInt("killedTown") == 0){
			if(col.gameObject.tag == "player"){
				rb2d.bodyType = RigidbodyType2D.Dynamic;
				pacing = true;
				StartCoroutine(Pacing());
			}
		}
	}
}
