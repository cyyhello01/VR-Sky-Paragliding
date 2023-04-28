using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.EventSystems;

public class testPhysics : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed;
    public float forwardSpeed;
    private Vector3 moveDirection;
    private Vector3 rotateDirection;
    private const int V = 10;

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

        rotateDirection = new Vector3(0, 0, moveX*100);
    }

    void Move()
    {
        rb.velocity = new Vector3(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed, moveDirection.z);

        Quaternion deltaRotation = Quaternion.Euler(rotateDirection * Time.fixedDeltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
}
