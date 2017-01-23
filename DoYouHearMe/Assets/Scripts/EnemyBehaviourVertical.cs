using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviourVertical : MonoBehaviour {
	
	public Rigidbody2D body;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D> ();
		body.velocity = new Vector2 (0,3f);
	}

	// Update is called once per frame
	void FixedUpdate () {

	}
	void OnTriggerEnter2D(){
		if(body.gameObject.transform.localPosition.y > 0){
			body.velocity = new Vector2 (0, -3f);
		}else if (body.gameObject.transform.localPosition.y < 0){
			body.velocity = new Vector2 (0, 3f);
		}

	}
}
