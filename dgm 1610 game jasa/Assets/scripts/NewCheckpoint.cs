using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCheckpoint : MonoBehaviour {

	public Rigidbody2D CC;
	public GameObject NC1;

	void OnTriggerEnter2D (Collider2D other) {
		if(other.name == "PC"){
			CC.transform.position = NC1.transform.position;
		}
	}		
}
