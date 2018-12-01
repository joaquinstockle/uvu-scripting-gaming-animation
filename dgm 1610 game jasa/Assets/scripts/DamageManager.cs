using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour {

	public int PointToAdd;
	private int JumpHeight = 4;
	public GameObject PC;

	void OnTriggerEnter2D (Collider2D other) {
		if(other.name == "PC"){
			HealthManager.Addpoints (PointToAdd);
			PC.GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
		}
	}
}
