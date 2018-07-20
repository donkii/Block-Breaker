using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	float mousePauseInBlocks;
    Vector3 paddlePos;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        

		mousePauseInBlocks = Input.mousePosition.x / Screen.width * 16;
        paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);
        paddlePos.x = Mathf.Clamp(mousePauseInBlocks, 0.5f, 15.5f);

        this.transform.position = paddlePos;
		
	}
}
