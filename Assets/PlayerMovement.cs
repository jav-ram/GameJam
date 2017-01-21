using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float speed = 3f;
	public Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
	}

	void Move(){
		speed = 3f;
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (new Vector2 (0, 1) * speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (new Vector2 (0, -1) * speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (new Vector2 (-1, 0) * speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (new Vector2 (1, 0) * speed * Time.deltaTime);
		}

	}

	void OnCollisionEnter2D(Collision2D other){
		Debug.Log("hit");
		speed = 0f;
	}
}
