using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {

	public static int Health;

	Text HealthText;

	// Use this for initialization
	void Start () {
		HealthText = GetComponent<Text>();

		Health = 100;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Health < 0)
			Health = 0;
		if (Health > 100)
			Health = 100;
		HealthText.text = " " + Health;	

	}

	public static void Addpoints (int PointToAdd) {
		Health += PointToAdd;
	}
}
