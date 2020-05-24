using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
        // act on compotents that are type Rigidbody
        // get access to rigidBody in bird 
        rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		ProcessInput();
	}

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space)) // can fly while rotating 
        {
			print("flying");
            rigidBody.AddRelativeForce(Vector3.up);
        }

        if (Input.GetKey(KeyCode.A))
        {
            print("rotating left");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            print("rotating right");
        }
    }
}
