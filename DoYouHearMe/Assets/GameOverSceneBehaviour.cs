using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverSceneBehaviour : MonoBehaviour {

	// Use this for initialization
	public Animator anim;
	public float timer;
	void Awake(){
		//anim.GetComponent <Animator> ();

	}

	void FixedUpdate(){
		timer += 0.01f;
		if (timer >= 1.9f){
			SceneManager.LoadScene ("Intro");
		}
	}

	void Start(){
		anim.Play ("GameOver");


	}
}
