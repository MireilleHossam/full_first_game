using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement; // taking the script playerMovement (as a reference) and enabling it

    public GameObject prizeSoundEffectsFeedback; // creating the object that will be instaniated

    public Text gems;
    public Text collectingPrizes; // accesing the "colleted Prizes Num."
    public int prizes = 0;

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
            Debug.Log( "Prizes" + prizes);
            collectingPrizes.text = prizes.ToString();
            other.gameObject.SetActive(false);
            Instantiate(prizeSoundEffectsFeedback); // means create the prefab object after the one triggered is deactivated
        }
    }



}
