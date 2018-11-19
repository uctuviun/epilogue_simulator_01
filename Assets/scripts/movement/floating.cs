using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floating : MonoBehaviour {


	Rigidbody2D rb2d;
	public float speed, time;


	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		StartCoroutine(Hover());
	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator Hover(){
		Vector2 up = new Vector2(0, 1);
		Vector2 down = new Vector2(0, -1);
		while(true){
			rb2d.AddForce(up * speed);
			yield return new WaitForSeconds(time);
			rb2d.AddForce(down * speed);
			yield return new WaitForSeconds(time);

//			rb2d.AddForce(down * speed);
//			yield return new WaitForSeconds(time);
		}
	}
}
