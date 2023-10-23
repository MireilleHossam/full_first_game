using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class ObstacleMovement : MonoBehaviour
    {
        public float movementScale = 2f;
        public float speed = 2f;


        // object moving within a certain distance with a ceratin speed
        void FixedUpdate()
        {
            float xPosition = Mathf.Sin(speed * Time.time) * movementScale;
            transform.position = new Vector3(xPosition, transform.position.y, transform.position.z);
        }
    }
}