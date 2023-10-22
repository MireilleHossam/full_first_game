using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour
{
    public GameObject[] wayPoints; // array
    int current = 0; // start position
    public float speed;
    float WPradius = 2; // max. distance to hit


    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(wayPoints[current].transform.position, transform.position) < WPradius)
        {
            current ++;
      
        }
        if (current >= wayPoints.Length)
        {
            current = 0;
        }
        transform.position =Vector3.MoveTowards(transform.position, wayPoints[current].transform.position, speed * Time.deltaTime);
    }
}
