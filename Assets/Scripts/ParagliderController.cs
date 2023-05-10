using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus;


public class ParagliderController : MonoBehaviour
{
    // Speed and turning variables
    public float speed = 10.0f;
    public float turnSpeed = 50.0f;

    // VR Input variables
    private Vector2 joystickInput;
    private Vector3 forwardVector;

    // Rigidbody and Collider references
    private Rigidbody rb;
    private CapsuleCollider collider;

    void Start()
    {
        // Get references to the Rigidbody and Collider components
        rb = GetComponent<Rigidbody>();
        collider = GetComponent<CapsuleCollider>();
        rb.useGravity = true;
    }

    void Update()
    {
        // Get joystick input from the Oculus Rift controller
        joystickInput = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);

        // Calculate the forward vector based on the camera orientation
        forwardVector = Camera.main.transform.forward;
        forwardVector.y = 0.0f;
        forwardVector.Normalize();

        // Apply speed and turning based on joystick input
        transform.Rotate(0, joystickInput.x * turnSpeed * Time.deltaTime, 0);
        rb.AddForce(forwardVector * speed * joystickInput.y, ForceMode.Acceleration);
    }
}

