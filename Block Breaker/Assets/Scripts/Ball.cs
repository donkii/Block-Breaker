using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private Paddle paddle;

    private Vector3 paddleToBallVector;
    private Rigidbody2D rb2d;
    private bool hasStarted = false;

    // Use this for initialization
    void Start () {
        paddle = GameObject.FindObjectOfType<Paddle>();
        paddleToBallVector = this.transform.position - paddle.transform.position;
        rb2d = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!hasStarted)
        {
            //Lock the ball relative to the paddle
            this.transform.position = paddle.transform.position + paddleToBallVector;

            //Launch the ball
            if (Input.GetMouseButtonDown(0))
            {
                rb2d.velocity = new Vector2(2f, 15f);
                hasStarted = true;
            }

           
        }
	}
}
