using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroPlay : MonoBehaviour {
	public Animator anim;
	public float timer;
	// Use this for initialization
	void Start () {
		anim.Play ("IntroAnimation");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timer += 0.01f;
		if (timer >= 2f){
			SceneManager.LoadScene ("Story");
		}
	}
}
