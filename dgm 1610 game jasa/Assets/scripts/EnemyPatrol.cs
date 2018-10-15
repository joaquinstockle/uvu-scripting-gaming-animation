﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour {

	//movement vairiables
	public float MoveSpeed;
	public bool MoveRight;

	//Wall check
	public Transform WallCheck;
	public float WallCheckRadius;
	public LayerMask WhatIsWall;
	private bool HittingWall;

	//Edge Check
	private bool NotAtEdge;
	public Transform EdgeCheck;


	// Use this for initialization
	void Start () {
		NotAtEdge = Physics2D.OverlapCircle(EdgeCheck.position, WallCheckRadius, WhatIsWall);

		HittingWall = Physics2D.OverlapCircle(WallCheck.position, WallCheckRadius, WhatIsWall);
		
		//Turn Around At Edge
		if(HittingWall || !NotAtEdge){
			MoveRight = !MoveRight;
		}

		if(MoveRight){
			transform.localScale = new Vector3(-9f,9f,1f);
			GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
		else {
			transform.localScale = new Vector3(9f,9f,1f);
			GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
