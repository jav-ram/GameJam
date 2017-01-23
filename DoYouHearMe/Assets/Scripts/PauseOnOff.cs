using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseOnOff : MonoBehaviour {
    bool on = false;

	// Use this for initialization
	void Start () {
 
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("p"))
        {
            if (!on)
            {
                Time.timeScale = 0f;
                on = true;
            }
            else
            {
                Time.timeScale = 1f;
                on = false;
            }
        }
	}

    void OnGUI()
    {
        if (on)
        {
            GUI.Label(new Rect((Screen.width/2)-90, Screen.height/2,180,100),"Paused (Press P to continue)");
        }
    }
}
