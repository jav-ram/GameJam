using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float speed = 6f;
    public float scale;
	public Collider2D enemie;
	public Animator cameraAnimation;
	public Rigidbody2D rb;
    public GameObject wave;


	private float currenPosX;
	private float currenPosY;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
        scale = wave.transform.localScale.x;
    }
	
	// Update is called once per frame
	void Update () {
		speed = 6f;
		Move ();
	}

	void Move(){
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {

            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(new Vector2(0, 1) * speed * Time.deltaTime);
                wave.transform.localScale = new Vector3(wave.transform.localScale.x + 0.1f, wave.transform.localScale.y + 0.1f, 0);

            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(new Vector2(0, -1) * speed * Time.deltaTime);
                wave.transform.localScale = new Vector3(wave.transform.localScale.x + 0.1f, wave.transform.localScale.y + 0.1f, 0);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(new Vector2(-1, 0) * speed * Time.deltaTime);
                wave.transform.localScale = new Vector3(wave.transform.localScale.x + 0.1f, wave.transform.localScale.y + 0.1f, 0);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(new Vector2(1, 0) * speed * Time.deltaTime);
                wave.transform.localScale = new Vector3(wave.transform.localScale.x + 0.1f, wave.transform.localScale.y + 0.1f, 0);
            }

        }
        
        else
        {
            wave.transform.localScale = new Vector3(wave.transform.localScale.x - 0.01f, wave.transform.localScale.y - 0.01f, 0);
            if (wave.transform.localScale.x <= .5f)
            {
                wave.transform.localScale = new Vector3(scale * .01f, scale * 0.01f, 0);
            }
        }
        
        if (wave.transform.localScale.x >= 1.5f)
        {
            wave.transform.localScale = new Vector3(scale * .01f, scale * .01f, 0);
        }

	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.CompareTag ("Enemie")) {
			Debug.Log ("Si Funca");
			//cameraAnimation.Play ("GameOver");
		}
	}
}
