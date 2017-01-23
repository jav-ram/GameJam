using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayWin : MonoBehaviour {
	public Animator anim;
	private float timer;
	// Use this for initialization
	void Start () {
		anim.Play ("WinAnim");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timer += 0.01f;
		if(timer >= 2f){
			SceneManager.LoadScene ("Intro");
		}
	}
}
