using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackPlayer : MonoBehaviour {
	public Transform enemie;
	public Rigidbody2D enemieBody;
	public Transform player;
	public Collider2D col;

	private bool trigger = false;

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag ("Player")){
			trigger = true;
			enemieBody.velocity = new Vector2 (0,0);
		}

	}

	void OnTriggerExit2D(Collider2D col){
		if(col.CompareTag ("Player")){
			trigger = false;
		}

	}


	void FixedUpdate(){
		if(trigger == true){
			enemieBody.velocity += new Vector2 (player.position.x - enemie.position.x , player.position.y - enemie.position.y) *Time.deltaTime ;
		
		}
		Debug.Log (trigger);

	}
}
