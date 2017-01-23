using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Instruccion : MonoBehaviour {

    public Button inst;
    public Button ret;
    public Button quit;
    public Button start;
    public Camera cam;
    public GameObject canv;
    public GameObject canv2;


	// Use this for initialization
	void Start () {
        inst.onClick.AddListener(instTrigger);
        ret.onClick.AddListener(retTrigger);
        quit.onClick.AddListener(Quit);
        start.onClick.AddListener(startTrigger);
        canv2.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void instTrigger()
    {
        cam.transform.position = new Vector3(30, 0,-1);
        canv2.SetActive(true);
        canv.SetActive(false);
    }

    void retTrigger() {
        cam.transform.position = new Vector3(0, 0, -1);
        canv2.SetActive(false);
        canv.SetActive(true);
    }

    void Quit() {
        Application.Quit();
    }

    void startTrigger() {
		SceneManager.LoadScene ("MainScene");
    }
}
