using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotRemoteControl : MonoBehaviour
{
    [Header("Control the speed of the Rover")]
    public float Speed = 10.0f;

    [Header("Control the turning speed of the Rover")]
    public float turnSpeed = 10.0f;

    private float roverSpeed;
    private float currentSpeed = 0f;

    void Start()
    {
        roverSpeed = Speed;
    }

    void Update()
    {
        // Read input from the gamepad's left stick vertical axis
        float moveInput = Input.GetAxis("Vertical");
        currentSpeed = roverSpeed * moveInput;

        // Read input from the gamepad's left stick horizontal axis for turning
        float turnInput = Input.GetAxis("Horizontal");
        float turn = turnSpeed * turnInput * Time.deltaTime;

        // Apply movement and turning
        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up, turn);
    }
    public void StopMoving()
    { 
        Speed = 0f;
        turnSpeed = 0f;
        Debug.Log("Robot stopped moving."); // Add this line for debugging
    }
}