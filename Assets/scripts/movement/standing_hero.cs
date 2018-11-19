using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class standing_hero : MonoBehaviour {

	Animator animator;
	Rigidbody2D rb2d;
	SpriteRenderer SpriteRenderer;
	CapsuleCollider2D capcoll;
	public Sprite blood;
	public int startPosition;

	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt("killedHero") == 0){
			rb2d = GetComponent<Rigidbody2D> ();
			animator = GetComponent<Animator>();
			SpriteRenderer = GetComponent<SpriteRenderer>();
			capcoll = GetComponent<CapsuleCollider2D>();
			animator.SetInteger ("state", startPosition);
		}
		if(PlayerPrefs.GetInt("killedHero") == 1){
			animator = GetComponent<Animator>();
			SpriteRenderer = GetComponent<SpriteRenderer> ();
			capcoll = GetComponent<CapsuleCollider2D>();
			SpriteRenderer.sprite = blood;
			capcoll.enabled = false;
			animator.enabled = false;
		}
	}

	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt("killMode") == 1 && PlayerPrefs.GetInt("killedHero") == 0){
			StartCoroutine(Exploding());
		}
		if(PlayerPrefs.GetInt("killedHero") == 1){
			rb2d.velocity = Vector2.zero;
			SpriteRenderer = GetComponent<SpriteRenderer> ();
			SpriteRenderer.sprite = blood;
			capcoll.enabled = false;
			animator.enabled = false;
		}
	}

	IEnumerator Exploding(){
		Debug.Log("ok go!");
		animator.enabled = true;
		animator.SetInteger ("state", 9);
		yield return new WaitForSeconds((this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length) -0.1f);
		PlayerPrefs.SetInt("killMode", 0);
		PlayerPrefs.SetInt("killedHero", 1);
	}
}
