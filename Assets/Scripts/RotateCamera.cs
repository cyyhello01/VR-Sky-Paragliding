using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotationAngle = 10f;
     

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            // Get the current rotation
            Quaternion currentRotation = transform.rotation;

            rotationAngle += rotationAngle ;

            // Calculate the new rotation
            Quaternion newRotation = Quaternion.Euler(0f, rotationAngle, 0f) * currentRotation;

            // Set the new rotation
            transform.rotation = newRotation;
        }
    }
}
