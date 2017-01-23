using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour {
    private Animator anim;
    private int lastKl;
	private float timer;
	// Use this for initialization
    
	void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow) && Time.timeScale == 1f)
        {
            anim.Play("movX");
            lastKl = (int)KeyCode.RightArrow;
        }

        else if (Input.GetKey(KeyCode.LeftArrow) && Time.timeScale == 1f)
        {
            anim.Play("Move_Iz");
            lastKl = (int)KeyCode.LeftArrow;
        }

        else if (Input.GetKey(KeyCode.DownArrow) && Time.timeScale == 1f)
        {
            anim.Play("walkFront");
            lastKl = (int)KeyCode.DownArrow;
        }

        else if (Input.GetKey(KeyCode.UpArrow) && Time.timeScale == 1f)
        {
            anim.Play("walkBack");
            lastKl = (int)KeyCode.UpArrow;
        }

        else if (lastKl == 273)
        {
            anim.Play("back");
        }
        
        else
        {
            anim.Play("front");
        }


	}
}
