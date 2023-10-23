using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float movementUpScale = 2f;
    public float speedUp = 2f;


    // object moving within a certain distance with a ceratin speed
    void Update()
    {
        float yPosition = Mathf.Sin(speedUp * Time.time) * movementUpScale;
        transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
    }
}
