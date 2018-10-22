using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calc : MonoBehaviour {

	public int Num1;
	public int Num2;
	private int Total;

	// Use this for initialization
	void Start () {

		Add(Num1,Num2);
		
	}

	public void Add(int one,int two){

		Total = one + two;

		// Debug "Total"

	}

	

}
