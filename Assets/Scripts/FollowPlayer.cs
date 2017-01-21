using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {
	public GameObject player;
	public float speed = 3f;

	private float offsetX;
	private float offsetY;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		offsetX = player.transform.position.x - transform.position.x;
		offsetY = player.transform.position.y - transform.position.y;

		if (offsetX > 1) {
			transform.Translate (new Vector2 (1, 0) * speed * Time.deltaTime);
		} else if (offsetX < -1) {
			transform.Translate (new Vector2 (-1, 0) * speed * Time.deltaTime);
		}

		if (offsetY > 1) {
			transform.Translate (new Vector2 (0, 1) * speed * Time.deltaTime);
		} else if (offsetY < -1) {
			transform.Translate (new Vector2 (0, -1) * speed * Time.deltaTime);
		}




	}
}
