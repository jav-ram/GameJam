using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayStory : MonoBehaviour {
	public Animator anim;
	private float timer;
	// Use this for initialization
	void Start () {
		anim.Play ("StoryAnim");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timer += 0.01f;
		if (timer >= 6f) {
			SceneManager.LoadScene ("Intro");
		}
	}
}
