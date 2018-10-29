using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killzone : MonoBehaviour {
	public float speed;
	private Rigidbody2D thisRigidbody;

	// Use this for initialization
	void Start () {
		thisRigidbody = GetComponent<Rigidbody2D>();
	}
	void OnCollisionEnter2D(Collision2D coll) {


		if (coll.gameObject.tag == "Player" || coll.gameObject.tag == "Obstacle" ){

			Destroy(coll.gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
		speed += 0.0001f;
		thisRigidbody.velocity = new Vector2 (speed, thisRigidbody.velocity.y);
	}
}
