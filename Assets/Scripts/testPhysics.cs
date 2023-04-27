using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class testPhysics : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed;
    public float forwardSpeed;
    private Vector3 moveDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Get a wild spin under control when the user
    // presses the spacebar.
    void Update()
    {
        ProcessInput();

    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInput()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        float moveZ = forwardSpeed;
        moveDirection = new Vector3(moveX, moveY, moveZ).normalized;
    }

    void Move()
    {
        rb.velocity = new Vector3(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed, moveDirection.z);
    }
}
