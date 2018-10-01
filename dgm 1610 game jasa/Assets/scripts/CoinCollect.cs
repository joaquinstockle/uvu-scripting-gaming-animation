using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour {

	public int PointToAdd;

	void OnTriggerEnter2D (Collider2D Other) {
		if (Other.GetComponent<Rigidbody2D> () == null)
			return;

		ScoreManager.Addpoints (PointToAdd);

		Destroy (gameObject);
	}
}
