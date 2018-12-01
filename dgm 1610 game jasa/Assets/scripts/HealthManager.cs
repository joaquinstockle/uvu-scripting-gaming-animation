using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {

	public static int Health;
	public LevelManager LevelManager;
	public bool Dead;
	
	Text HealthText;

	
	// Use this for initialization
	void Start () {
		HealthText = GetComponent<Text>();

		Health = 100;
		
		LevelManager = FindObjectOfType <LevelManager>();
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Health < 0)
			Health = 0;
		if (Health > 100)
			Health = 100;
		HealthText.text = " " + Health;	

		if(Health <= 0)
			Dead = true;
		if(Health > 0)
			Dead = false;
		
		if(Dead){

			LevelManager.RespawnPlayer();
			Health = 100;
		}

	}

	
	
	

	public static void Addpoints (int PointToAdd) {
		Health += PointToAdd;
	}


		
}
