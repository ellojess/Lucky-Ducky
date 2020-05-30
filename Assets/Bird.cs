using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] float rcsThrust = 100f; // turn num to float
    [SerializeField] float mainThrust = 50f;
    Rigidbody rigidBody;

    // Use this for initialization
    void Start()
    {
        // act on compotents that are type Rigidbody
        // get access to rigidBody in bird 
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Fly();
        Rotate();
    }

    private void Fly()
    {
        if (Input.GetKey(KeyCode.Space)) // can fly while rotating 
        {
            print("flying");
            rigidBody.AddRelativeForce(Vector3.up * mainThrust);
        }
    }

    private void Rotate()
    {
        // prevent rotation movement from being as drast by taking manual control of rotation
        rigidBody.freezeRotation = true;
        float rotationThisFrame = rcsThrust * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
        {
            print("rotating left");
            // determine speed of rotation based on the length of frame
         
            transform.Rotate(Vector3.forward * rotationThisFrame);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            print("rotating right");
            transform.Rotate(-Vector3.forward * rotationThisFrame);
        }
        rigidBody.freezeRotation = false; // resume physics control of rotation
    }

}