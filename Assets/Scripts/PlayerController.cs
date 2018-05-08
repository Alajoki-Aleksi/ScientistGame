using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	public float jumpLimit;
	Animator anim;
    AudioSource sound;

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
		anim = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
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
			anim.SetInteger("State", 3);
		} 
		else if (speedup) {
			thisRigidbody.velocity = new Vector2 ((moveSpeed * 3f), thisRigidbody.velocity.y);
			anim.SetInteger("State", 1);
		} 
		else {
			thisRigidbody.velocity = new Vector2 (moveSpeed, thisRigidbody.velocity.y);
			anim.SetInteger("State", 0);
		}


		// Hyppääminen
		if (hasJumped == false) {
			if (jump) {
                sound.Play();
                if (jumpForce < jumpLimit) {
					jumpForce++;
					thisRigidbody.velocity = new Vector2 (thisRigidbody.velocity.x, jumpForce);
					anim.SetInteger("State", 2);
                    
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