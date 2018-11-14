using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    //only public objects will appear in object inspector in unity
    public GameObject Ball;
    public GameObject PlayerCamera;

    public float ballDistance = 2f;
    public float ballThrowingForce = 5f;

    public bool holdingBall = true;

    // Use this for initialization
    void Start () {
        //disabled gravity of the ball
        Ball.GetComponent<Rigidbody>().useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
        //set the position of the ball right in front of the player (camera acctualy)
        if (holdingBall)
        {
            Ball.transform.position = PlayerCamera.transform.position + PlayerCamera.transform.forward * ballDistance;
            // 0 is left button
            if (Input.GetMouseButtonDown(0))
            {
                holdingBall = false;
                //turn on the gravity
                Ball.GetComponent<Rigidbody>().useGravity = true;
                Ball.GetComponent<Rigidbody>().AddForce(PlayerCamera.transform.forward * ballThrowingForce);
            }
        }
	}
}
