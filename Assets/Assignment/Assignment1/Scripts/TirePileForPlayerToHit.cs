using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TirePileForPlayerToHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //This has a debug log that checks if the player runs into a tire on the road. This also uses the OnCollisionEnter2D and Exit2D
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Player Hit Tire");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Player is no longer hitting tire");
    }
}
