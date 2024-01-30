using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAssignment1 : MonoBehaviour
{
    //This sets all the floats that are needed for player movement
    Rigidbody2D rigidbodyPlayer;
    float acceleration;
    float steering;
    public float forwardSpeed = 500;
    public float steeringSpeed = 20;
    public float maxSpeed = 650;
    void Start()
    {
        rigidbodyPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        acceleration = Input.GetAxis("Vertical");
        steering = Input.GetAxis("Horizontal");

        //This line of code has the player get a speed boost while pressing space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            forwardSpeed = 800;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            forwardSpeed = 500;
        }

    }

    //This code manages the speed of the player and increases and decreses speed based on how fast its going simulating physics
    private void FixedUpdate()
    {
        rigidbodyPlayer.AddTorque(steering * -steeringSpeed * Time.deltaTime);

        Vector2 force = transform.up * acceleration * forwardSpeed * Time.deltaTime;

        if (rigidbodyPlayer.velocity.magnitude < maxSpeed)
        {
            rigidbodyPlayer.AddForce(force);

        }

    }
}