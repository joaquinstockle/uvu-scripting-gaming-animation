using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Times : MonoBehaviour {

	public string Abc;

	// Use this for initialization
	void Start () {

		if(Abc == "party")
			print("It is " + Abc + " time.");
		// else(Abc == "sleep")
		// 	print("It is " + Abc + " time.");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
