using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigame_move : MonoBehaviour {

	Rigidbody2D rb2d;
	public int whichone;
	Animator animator;
	CircleCollider2D collider;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator>();
		collider = GetComponent<CircleCollider2D>();
	}

	// Update is called once per frame
	void Update () {

		if(PlayerPrefs.GetInt("minigameOn") == 0){
			Vector2 movement = new Vector2(0, 0);

			if (Input.GetKey("left")){
				movement = new Vector2(-1, 0);
			}
			if (Input.GetKey("right")){
				movement = new Vector2(1, 0);
			}
			if (Input.GetKey("up")){
				movement = new Vector2(0, 1);
			}
			if (Input.GetKey("down")){
				movement = new Vector2(0, -1);
			}
			rb2d.AddForce(movement * 5);
		}
		else{
			Debug.Log("killit");
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if(whichone == 4){
			if(col.gameObject.tag == "piece4"){
				rb2d.velocity = Vector2.zero;
				rb2d.bodyType = RigidbodyType2D.Kinematic;
				collider.enabled = false;
				PlayerPrefs.SetInt("miniSpawnLevel", 1);
				StartCoroutine(Dissolve());
			}
			if(col.gameObject.tag == "piece3"){
				rb2d.velocity = Vector2.zero;
				rb2d.bodyType = RigidbodyType2D.Kinematic;
				collider.enabled = false;
				PlayerPrefs.SetInt("miniSpawnLevel", 2);
				StartCoroutine(Dissolve());
			}
			if(col.gameObject.tag == "piece2"){
				rb2d.velocity = Vector2.zero;
				rb2d.bodyType = RigidbodyType2D.Kinematic;
				collider.enabled = false;
				PlayerPrefs.SetInt("miniSpawnLevel", 3);
				StartCoroutine(Dissolve());
			}
			if(col.gameObject.tag == "piece1"){
				rb2d.velocity = Vector2.zero;
				rb2d.bodyType = RigidbodyType2D.Kinematic;
				collider.enabled = false;
				PlayerPrefs.SetInt("miniSpawnLevel", 4);
				StartCoroutine(Dissolve());
			}
		}
		if(whichone == 3){

			if(col.gameObject.tag == "piece4"){
				rb2d.velocity = Vector2.zero;
				rb2d.bodyType = RigidbodyType2D.Kinematic;
				collider.enabled = false;
				PlayerPrefs.SetInt("miniSpawnLevel", 2);
				StartCoroutine(Dissolve());
			}
			if(col.gameObject.tag == "piece3"){
				rb2d.velocity = Vector2.zero;
				rb2d.bodyType = RigidbodyType2D.Kinematic;
				collider.enabled = false;
				PlayerPrefs.SetInt("miniSpawnLevel", 2);
				StartCoroutine(Dissolve());
			}
			if(col.gameObject.tag == "piece2"){
				rb2d.velocity = Vector2.zero;
				rb2d.bodyType = RigidbodyType2D.Kinematic;
				collider.enabled = false;
				PlayerPrefs.SetInt("miniSpawnLevel", 3);
				StartCoroutine(Dissolve());
			}
			if(col.gameObject.tag == "piece1"){
				rb2d.velocity = Vector2.zero;
				rb2d.bodyType = RigidbodyType2D.Kinematic;
				collider.enabled = false;
				PlayerPrefs.SetInt("miniSpawnLevel", 4);
				StartCoroutine(Dissolve());
			}
		}
		if(whichone == 2){
			if(col.gameObject.tag == "piece4"){
				rb2d.velocity = Vector2.zero;
				rb2d.bodyType = RigidbodyType2D.Kinematic;
				collider.enabled = false;
				PlayerPrefs.SetInt("miniSpawnLevel", 3);
				StartCoroutine(Dissolve());
			}
			if(col.gameObject.tag == "piece3"){
				rb2d.velocity = Vector2.zero;
				rb2d.bodyType = RigidbodyType2D.Kinematic;
				collider.enabled = false;
				PlayerPrefs.SetInt("miniSpawnLevel", 3);
				StartCoroutine(Dissolve());
			}
			if(col.gameObject.tag == "piece2"){
				rb2d.velocity = Vector2.zero;
				rb2d.bodyType = RigidbodyType2D.Kinematic;
				collider.enabled = false;
				PlayerPrefs.SetInt("miniSpawnLevel", 3);
				StartCoroutine(Dissolve());
			}
			if(col.gameObject.tag == "piece1"){
				rb2d.velocity = Vector2.zero;
				rb2d.bodyType = RigidbodyType2D.Kinematic;
				collider.enabled = false;
				PlayerPrefs.SetInt("miniSpawnLevel", 4);
				StartCoroutine(Dissolve());
			}
		}
		if(whichone == 1){
			if(col.gameObject.tag == "piece1"){
				rb2d.velocity = Vector2.zero;
				rb2d.bodyType = RigidbodyType2D.Kinematic;
				collider.enabled = false;
				PlayerPrefs.SetInt("miniSpawnLevel", 4);
				StartCoroutine(Dissolve());
			}
			if(col.gameObject.tag == "piece2"){
				rb2d.velocity = Vector2.zero;
				rb2d.bodyType = RigidbodyType2D.Kinematic;
				collider.enabled = false;
				PlayerPrefs.SetInt("miniSpawnLevel", 4);
				StartCoroutine(Dissolve());
			}
			if(col.gameObject.tag == "piece3"){
				rb2d.velocity = Vector2.zero;
				rb2d.bodyType = RigidbodyType2D.Kinematic;
				collider.enabled = false;
				PlayerPrefs.SetInt("miniSpawnLevel", 4);
				StartCoroutine(Dissolve());
			}
			if(col.gameObject.tag == "piece4"){
				rb2d.velocity = Vector2.zero;
				rb2d.bodyType = RigidbodyType2D.Kinematic;
				collider.enabled = false;
				PlayerPrefs.SetInt("miniSpawnLevel", 4);
				StartCoroutine(Dissolve());
			}
		}

	}

	IEnumerator Dissolve(){
		animator.SetInteger ("state", 1);
		yield return new WaitForSeconds(.3f);
		Destroy (this.gameObject);
	}
}
