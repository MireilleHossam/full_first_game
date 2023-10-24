using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationMovement : MonoBehaviour
{
    public float rotationSpeed= 10f;
    public Vector3 newPosition= new Vector3 (0,1f,0); // Increasing the rotation by one
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position,Vector3.up,rotationSpeed*Time.deltaTime);
    }
}
