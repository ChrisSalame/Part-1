using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeCheck : MonoBehaviour
{
    public SpriteRenderer Sensor;
    // Start is called before the first frame update
    void Start()
    {
        if (Sensor != null)
        {
            Sensor.color = Color.clear;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Sensor != null) Sensor.color = Color.green;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (Sensor != null) Sensor.color = Color.clear;
    }
}
