using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	public float jumpLimit;

	private Rigidbody2D thisRigidbody;
	private Collider2D thisCollider;
	int jumpForce = 0;

	// Määrittää layerin jossa on platformit joilla pelaaja kävelee
	public LayerMask groundLayer;
	bool hasJumped = false;



	// Use this for initialization
	void Start () {
		thisRigidbody = GetComponent<Rigidbody2D>();
		thisCollider = GetComponent<Collider2D>();
	}

	// Update is called once per frame
	void Update () {
		
		// Onko pelaaja maassa?
		bool touchingGround = Physics2D.IsTouchingLayers (thisCollider, groundLayer);

		// Onko napit pohjassa?
		bool slowdown = Input.GetKey(KeyCode.LeftArrow);
		bool speedup = Input.GetKey(KeyCode.RightArrow);
		bool jump = Input.GetKey(KeyCode.Space);







		// Pelaajan liikkumisnopeudet
		if (slowdown) {
			thisRigidbody.velocity = new Vector2 (-(moveSpeed * 4f), thisRigidbody.velocity.y);
		} 
		else if (speedup) {
			thisRigidbody.velocity = new Vector2 ((moveSpeed * 3f), thisRigidbody.velocity.y);
		} 
		else {
			thisRigidbody.velocity = new Vector2 (moveSpeed, thisRigidbody.velocity.y);
		}


		// Hyppääminen
		if (hasJumped == false) {
			if (jump) {
				
				if (jumpForce < jumpLimit) {
					jumpForce++;
					thisRigidbody.velocity = new Vector2 (thisRigidbody.velocity.x, jumpForce);
				}
			} 
			else {
				jumpForce = 0;
				hasJumped = true;
			}
		}


		if (touchingGround) {
			jumpForce = 0;
			hasJumped = false;
		}
	}


}