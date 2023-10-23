using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement; // taking the script playerMovement (as a reference) and enabling it
   // public GameManager gameManager; // reference to the GameManager to identify the state of the game manager INSTEAD WE CAN FIND THE TYPE BECAUSE IT WILL WORK BOTH IF THE GAME IS IN THE SCENE OR NOT
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
            FindObjectOfType<GameManager>().EndGame(); // bring the method engame from one of the states in the GameManger script
                    
        }

    }

}
