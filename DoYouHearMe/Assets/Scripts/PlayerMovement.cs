using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;
    public float scale;
    public Rigidbody2D rb;
    public GameObject wave;
    public float magnitude = 50f;
    public float time;

    private float pX;
    private float pY;
    // Use this for initialization
    void Start()
    {
        pX = 0;
        pY = 0;
        time = Time.timeScale;
    }

    // Update is called once per frame
    void Update()
    {

        if (time > 0.01f)
        {
            Move();
        }

    }

    void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            wave.transform.localScale = new Vector3(wave.transform.localScale.x + 0.1f, wave.transform.localScale.y + 0.1f, 0);
            if (Input.GetKey(KeyCode.UpArrow))
            {
                pY = magnitude;
                //wave.transform.localScale = new Vector3(wave.transform.localScale.x + 0.1f, wave.transform.localScale.y + 0.1f, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                pY = -magnitude;
                //wave.transform.localScale = new Vector3(wave.transform.localScale.x + 0.1f, wave.transform.localScale.y + 0.1f, 0);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                pX = -magnitude;
                //wave.transform.localScale = new Vector3(wave.transform.localScale.x + 0.1f, wave.transform.localScale.y + 0.1f, 0);

            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                pX = magnitude;
                //wave.transform.localScale = new Vector3(wave.transform.localScale.x + 0.1f, wave.transform.localScale.y + 0.1f, 0);
            }

            if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
            {
                pX = 0f;
                pY = 0f;
                wave.transform.localScale = new Vector3(0.1f, 0.1f, 0f);
            }

            if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow))
            {
                pY = 0f;
            }

            if (!Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
            {
                pX = 0f;
            }

        }
        else
        {
            pX = 0f;
            pY = 0f;
            wave.transform.localScale = new Vector3(0.1f, 0.1f, 0f);
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



        rb.velocity = (new Vector2(pX, pY) * speed * Time.deltaTime);
    }


}