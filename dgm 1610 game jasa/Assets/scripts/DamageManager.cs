using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour {

	public int PointToAdd;

	void OnTriggerEnter2D (Collider2D other) {
		if(other.name == "PC"){
			HealthManager.Addpoints (PointToAdd);
		}
	}
}
