using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ObstacleSpinner : MonoBehaviour
{
    //Sets up the variables needed for spinning
    public float spinSpeed = 300;
    public float pushingForce = 50;
    Rigidbody2D obstaclerigidBody;
    Vector2 movement;
    
    // Start is called before the first frame update
    void Start()
    {
        //This code sets up the rigid body obstacle and sets it
        obstaclerigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //This codemakes the balls rotate as it pushes the balls in a circular pattarn by rotating the square. The square is rotating and then pushing the circle
        transform.Rotate(Vector3.forward, -spinSpeed * Time.deltaTime);

    }


}
