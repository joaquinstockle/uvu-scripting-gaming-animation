using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

	public int Num = 40;



	// Use this for initialization
	void Start () {

		while(Num > 0){
			print("Countdown" + Num);
			Num --;

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
