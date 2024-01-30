using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeCheck : MonoBehaviour
{
    public SpriteRenderer Sensor;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject + "Hitting Checkpoint");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject + "Leaving Checkpoint");
    }
}
