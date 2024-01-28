using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAssignment1 : MonoBehaviour
{
    Rigidbody2D rigidbodyPlayer;
    float acceleration;
    float steering;
    public float forwardSpeed = 250;
    public float steeringSpeed = 30;
    public float maxSpeed = 250;
    void Start()
    {
        rigidbodyPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        acceleration = Input.GetAxis("Vertical");
        steering = Input.GetAxis("Horizontal");
    }

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