using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ObstacleSpinner : MonoBehaviour
{
    public float spinSpeed = 300;
    public float pushingForce = 50;
    Rigidbody2D obstaclerigidBody;
    Vector2 movement;
    
    // Start is called before the first frame update
    void Start()
    {
        obstaclerigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, -spinSpeed * Time.deltaTime);

    }
}
