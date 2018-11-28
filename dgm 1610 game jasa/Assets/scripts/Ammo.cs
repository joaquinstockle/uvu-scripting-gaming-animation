using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour {

	public int PointToAdd;

	void OnTriggerEnter2D (Collider2D Other) {
		if (Other.GetComponent<Rigidbody2D> () == null)
			return;

		AmmoManager.Addpoints (PointToAdd);

		Destroy (gameObject);
	}
}
