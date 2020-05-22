using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
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
