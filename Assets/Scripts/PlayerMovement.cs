using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f; // force value applied forward
    public float sideWaysForce = 500f;  // force value applied on the side to move the player with keys
    
    void FixedUpdate()
    {
        //force applied to player to move forward
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // move player right and left using KEYS
        //To the RIGHT
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        //To the LEFT
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}

