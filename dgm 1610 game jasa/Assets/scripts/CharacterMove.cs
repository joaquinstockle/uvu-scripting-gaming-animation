using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

	public int MoveSpeed; 
	public float JumpHeight;
	private bool DoubleJump;

	// Player Grounded Variables
	public Transform GroundCheck;
	public float GroundCheckRadius;
	public LayerMask WhatIsGround;
	private bool Grounded;

	// Non Stick Player
	private float MoveVelocity;

	public Animator animator;

	// Use this for initialization
	void Start () {
		print("Hello World");

			//Animation
			// animator.SetBool("isJumping", false);
			// animator.SetBool("isWalking", false);
	}
	
	void FixedUpdate () {
		Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
	}
	// Update is called once per frame
	void Update () {
		
		// This makes the character jump
		if(Input.GetKeyDown (KeyCode.Space)&& Grounded){
			Jump();
		}

		//Double Jump Code
		if(Grounded)
			DoubleJump = false;
			// animator.SetBool("isJumping", false);

		if(Input.GetKeyDown (KeyCode.Space)&& !DoubleJump && !Grounded){
			Jump();
			DoubleJump = true;
		}

		//Non Stick Player
		MoveVelocity = 0f;
		
		// This cod makes the character move from side to side using the A&D keys.
		if(Input.GetKey (KeyCode.D)){
			// 	GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			MoveVelocity = MoveSpeed;
			// animator.SetBool("isWalking", true);
		}
		else if(Input.GetKeyUp (KeyCode.D)){
			// animator.SetBool("isWalking", false);
		}

		
		 

		if(Input.GetKey (KeyCode.A)){
			// GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			MoveVelocity = -MoveSpeed;
			// animator.SetBool("isWalking", true);
		}
		else if(Input.GetKeyUp (KeyCode.A)){
			// animator.SetBool("isWalking", false);
		}

		GetComponent<Rigidbody2D>().velocity = new Vector2(MoveVelocity, GetComponent<Rigidbody2D>().velocity.y);

		//Player Flip
		if (GetComponent<Rigidbody2D>().velocity.x > 0){
			transform.localScale = new Vector3(6f,6f,1f);
		}
		else if (GetComponent<Rigidbody2D>().velocity.x < 0){
			transform.localScale = new Vector3(-6f,6f,1f);
		}
	}

	public void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
		// animator.SetBool("isJumping", true);
	}
}
