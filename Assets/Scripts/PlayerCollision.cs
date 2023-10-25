using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement; // taking the script playerMovement (as a reference) and enabling it
    public int prizes =0;

    public GameObject prizeSoundEffectsFeedback; // creating the object that will be instaniated
    
    void Start()
    {

    }
    // collision built-in method allows the player to see the object hitting
   public void OnCollisionEnter(Collision collisionInfo)
    {
   if (collisionInfo.collider.tag == "Obstacle")
    {
         Debug.Log("WE HIT SOMETHING!!");
         collisionInfo.gameObject.GetComponent<SFXPlayer>().PlaySFX();
         FindObjectOfType<GameManager>().EndGame(); // bring the method engame from one of the states in the GameManger script
         
    }
   }

    // makes the player move through the object
     void OnTriggerEnter(Collider other)
    {
            if (other.gameObject.CompareTag("Prizes"))
        {
            Debug.Log("Collecting Points!!");
            prizes++;
            other.gameObject.SetActive(false);
            Instantiate(prizeSoundEffectsFeedback); // means create the prefab object after the one triggered is deactivated
        }
    }



}
