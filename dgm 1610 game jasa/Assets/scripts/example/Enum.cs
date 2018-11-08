using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum : MonoBehaviour {

	enum Inventory {cheese = 4, meat = 10, sword = 1, shield = 1, map = 3, backpack = 1, bow = 1, arrows = 24};



	// Use this for initialization
	void Start () {

		print("Cheese = " + Inventory.cheese);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
