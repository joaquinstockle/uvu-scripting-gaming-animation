using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corditionals : MonoBehaviour {

	public string Weather;



	// Use this for initialization
	void Start () {
		if(Weather == "Raining")
			print("Weather is " + Weather);
		else if(Weather == "Snowing")
			print("Weather is " + Weather);
		else if(Weather == "Cloudy")
			print("Weather is " + Weather);
		else
			print("Weather is Clear");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
