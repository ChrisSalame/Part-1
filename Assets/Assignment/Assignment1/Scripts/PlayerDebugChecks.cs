using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDebugChecks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //This uses the OnTriggerEnter2D to debug if the player hits the halfway point
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject + "Hitting Checkpoint");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject + "Leaving Checkpoint");
    }
}
