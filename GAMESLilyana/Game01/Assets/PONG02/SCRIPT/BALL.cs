using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BALL : MonoBehaviour {

	private Rigidbody2D rbBall;
	private Vector2 vel;

	// Use this for initialization
	void Start () {

		rbBall = GetComponent<Rigidbody2D> ();
		Invoke ("GoBall", 2);

	}


	void GoBall() {
		float rand = Random.Range (0, 2);
		if(rand<1){
			rbBall.AddForce (new Vector2 (20, -15));
		}
		else{
			rbBall.AddForce (new Vector2 (-20, -15));
		}
	}
	void OnCollisionEnter2D (Collision2D coll) {
		if (coll.collider.CompareTag ("PLAYER")) {
			vel.x = rbBall.velocity.x;
			vel.y = (rbBall.velocity.y / 2.0f ) + (coll.collider.attachedRigidbody.velocity.y / 3.0f);
			rbBall.velocity=vel;
		}
	}


}
