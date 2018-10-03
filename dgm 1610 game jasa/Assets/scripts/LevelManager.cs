using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject CurrentCheckpoint;
	private Rigidbody2D Player;

	// Particles
	public GameObject DeathParticle;
	public GameObject RespawnParticle;

	//Respawn Delay
	public float RespawnParticle;

	//Point Penalty on Death
	public int PointPenaltyOnDeath;

	//Store Gravity Value
	private float GravityStore;

	//Use This For Initialization
	void Start () {
		player = FindObjectOfType<Rigidbody2D> ();
	
	}

	public void RespawnPlayer(){
		StartCoroutine ("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo(){
		//Generate Death Particle
		Instantiate (DeathParticle, player.transform.position, player.transform.rotation);
		//Hide Player
		player.enable = false;
		player.GetComponent<Rigidbody2D>().enable = false;
		//Gravity Reset
		GravityStore = player.GetComponent<Rigidbody2D>().GravityScale;
		
	}
}
