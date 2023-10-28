using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    //UI ELEMENTS DISPLAYED ON THE SCREEN
    public Transform player; // reference to the player
    public Text scoreText; //reference to the text
    

    //VARIABLES THAT WILL HOLD THE VALUES OF THE ABOVE ELEMENTS
    public float gemzCount =0;

    private void Start()
    {
        
      
    }





    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
        

    }
}
