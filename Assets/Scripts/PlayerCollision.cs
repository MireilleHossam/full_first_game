using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement; // taking the script playerMovement (as a reference) and enabling it
     void Start()
    {
       
    }
    // collision built-in method
    public void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag== "Obstacle")
        {
            Debug.Log("WE HIT SOMETHING!!");
            // movement.enabled = false;
            collisionInfo.gameObject.GetComponent<SFXPlayer>().PlaySFX();

                    
        }

    }

}
