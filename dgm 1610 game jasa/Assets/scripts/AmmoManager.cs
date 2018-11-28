using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoManager : MonoBehaviour {

	public static int Ammo;

	Text AmmoText;

	// Use this for initialization
	void Start () {
		AmmoText = GetComponent<Text>();

		Ammo = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Ammo < 0)
			Ammo = 0;
		if (Ammo > 30)
			Ammo = 30;
		AmmoText.text = " " + Ammo;	

		if(Input.GetKeyDown(KeyCode.RightControl))
			Ammo += -1;
	}

	public static void Addpoints (int PointToAdd) {
		Ammo += PointToAdd;
	}
}
