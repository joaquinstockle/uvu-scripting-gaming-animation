using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

	public int MoveSpeed; 
	public float JumpHeight;

	// Player Grounded Variables
	public Transform GroundCheck;
	public float GroundCheckRadius;
	public LayerMask WhatIsGround;
	private bool Grounded;

	// Use this for initialization
	void Start () {
		print("Hello World");
	}
	
	void FixedUpdate () {
		Grounded = Physics2D.OverlapCircle(GroundCheck.posotion, GroundCheckRadius, WhatIsGround);
	}
	// Update is called once per frame
	void Update () {
		
		// This makes the character jump
		if(Input.GetKeyDown (KeyCode.Space)&& Grounded){
			Jump();
		}
	}

	public void Jump(){
		GetComponent<Rigidbody2D>().velocity + new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
	}
}
