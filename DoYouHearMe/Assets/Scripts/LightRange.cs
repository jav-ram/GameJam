using UnityEngine;
using System.Collections;

public class LightRange : MonoBehaviour {


	public Light lt;
	public GameObject wave;

	private float ltAngle;
	private float scale;

	// Use this for initialization
	void Start () {
		ltAngle = lt.spotAngle;
		scale = wave.transform.localScale.x;
	}
	
	// Update is called once per frame
	void Update () {

			if (lt.spotAngle <= ltAngle) {
				if (Input.GetKey (KeyCode.Space) && Time.timeScale == 1) {
					lt.spotAngle = 120;
					//Debug.Log ("jump");
				}
			} else {
				lt.spotAngle = lt.spotAngle - 1;
				//Debug.Log ("disminuyendo");
			}

			if (wave.transform.localScale.x <= scale) {
				if (Input.GetKey (KeyCode.Space) && Time.timeScale == 1) {
					wave.transform.localScale = new Vector3 (scale * 20f, scale * 20f, 0);
					//Debug.Log ("jump");
				}
			} else {
				wave.transform.localScale = new Vector3 (wave.transform.localScale.x - 0.035f, wave.transform.localScale.y - 0.035f, 0);
			}
		}

	}

