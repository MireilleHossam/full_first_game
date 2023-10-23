using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//responsiable for the GAME STATESSSSS ( ex. restart..)
public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false; // condition to stop the player from continuing movement after collision

    public float delayTheRestart = 1f;
    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER!!!!");
            Invoke("Restart", delayTheRestart); // delay the restart with a certain timing
        }
        
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // acessing the opened scene in unity

    }

}
