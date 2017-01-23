using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
	private float lastKl;
	private float timer;
	public Animator anim;
	// Use this for initialization
	void Start () {
		
	}

	void Update(){
		if (Input.GetKey(KeyCode.RightArrow))
		{
			lastKl = (int)KeyCode.RightArrow;
		}

		else if (Input.GetKey(KeyCode.LeftArrow))
		{
			lastKl = (int)KeyCode.LeftArrow;
		}

		else if (Input.GetKey(KeyCode.DownArrow))
		{
			lastKl = (int)KeyCode.DownArrow;
		}

		else if (Input.GetKey(KeyCode.UpArrow))
		{
			lastKl = (int)KeyCode.UpArrow;
		}
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if (other.CompareTag ("Enemie")) {
			if (lastKl == (int)KeyCode.UpArrow) {
				Time.timeScale = 0.25f;
				anim.Play ("BackDeath");

			} else {
				Time.timeScale = 0.25f;
				anim.Play ("FrontDeath");

			}

			Time.timeScale = 1f;
			SceneManager.LoadScene ("GameOver");


		}
	}
}
