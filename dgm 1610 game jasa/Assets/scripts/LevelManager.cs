using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject CurrentCheckpoint;
	public Rigidbody2D Player;

	// Particles
	public GameObject DeathParticle;
	public GameObject RespawnParticle;

	//Respawn Delay
	public float RespawnDelay;

	//Point Penalty on Death
	public int PointPenaltyOnDeath;

	//Store Gravity Value
	private float GravityStore;

	//Use This For Initialization
	void Start () {
		// Player = FindObjectOfType<Rigidbody2D> ();
	
	}

	public void RespawnPlayer(){
		StartCoroutine ("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo(){
		//Generate Death Particle
		Instantiate (DeathParticle, Player.transform.position, Player.transform.rotation);
		//Hide Player
		// Player.enable = false;
		Player.GetComponent<Renderer>().enabled = false;
		//Gravity Reset
		GravityStore = Player.GetComponent<Rigidbody2D>().gravityScale;
		Player.GetComponent<Rigidbody2D>().gravityScale = 0f;
		Player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		//Point Penalty
		ScoreManager.Addpoints (-PointPenaltyOnDeath);
		//Dying Message
		Debug.Log ("You Died");
		//Respawn Delay
		yield return new WaitForSeconds (RespawnDelay);
		//Gravity Restore
		Player.GetComponent<Rigidbody2D>().gravityScale = GravityStore;
		//Match player transform position
		Player.transform.position = CurrentCheckpoint.transform.position;
		//Slow player
		//Player.enable = false
		Player.GetComponent<Renderer>().enabled = true;
		//Spawn Partical
		Instantiate (RespawnParticle, CurrentCheckpoint.transform.position, CurrentCheckpoint.transform.rotation);

	}
}
