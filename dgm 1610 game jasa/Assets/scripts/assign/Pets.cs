using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Pets : MonoBehaviour {

	public string[] Cats;

	// Use this for initialization
	void Start () {

		Cats = new string[5];

		Cats[0] = "fat one";
		Cats[1] = "lazy one";
		Cats[2] = "hyper one";
		Cats[3] = "long one";
		Cats[4] = "evil one";
		
		foreach(string item in Cats){
			print("*points at cat* The " + item);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
