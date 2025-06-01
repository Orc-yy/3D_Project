using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float turnSpeed= 45.0f;
    private float Speed = 20.0f;
    private float horizontalInput;
    private float forwardInput;
    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move the vehicle foward
        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput * Speed);
        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
