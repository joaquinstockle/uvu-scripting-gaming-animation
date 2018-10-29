using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switches : MonoBehaviour {

	public int num;
	public string name;

	// Use this for initialization
	void Start () {

		// if(num == 10){
		// 	print("Hurray you picked ten");
		// }

		// else if(num == 9)
		// 	print("Hurray you picked nine");

		// else{
		// 	print("Boo. You didnt get ten");
		// }
		
		switch(num){

			case 1:
				print("you picked " + num);
			break;
			case 2:
				print("you picked " + num);
			break;
			case 3:
				print("you picked " + num);
			break;
			case 4:
				print("you picked " + num);
			break;
			default:
				print("i dont understand " + num);
			break;
		}

		switch(name){
			case "Jason":
				print("welcome to camp crystal lake " + name);
			break;

			case "Michael":
				print("welcome " + name);
			break;

			case "Freddie":
				print("welcome to elm street " + name);
			break;

			case "LeatherFace":
				print("hi " + name);
			break;

			default:
				print("I dont know " + name);
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
