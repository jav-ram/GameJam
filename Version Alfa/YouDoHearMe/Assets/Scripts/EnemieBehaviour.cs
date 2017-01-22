﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class EnemieBehaviour : MonoBehaviour {
	public Rigidbody2D body;
	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D> ();
		body.velocity = new Vector2 (3f,0);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}
	void OnTriggerExit2D(Collider2D other){
		if(body.gameObject.transform.localPosition.x > 0){
			body.velocity = new Vector2 (-3f, 0);
		}else if (body.gameObject.transform.localPosition.x < 0){
			body.velocity = new Vector2 (3f, 0);
		}

	}

	void OntriggerEnter2D(Collider2D col){
		if(col.CompareTag ("Player")){
			
		}
	}
}
