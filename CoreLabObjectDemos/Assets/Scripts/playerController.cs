using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private float speed = 6f;
    private float gravity = 8f;

    private Vector3 MoveDirection = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // playerController is the variable name I've declared for the CharacterController
        CharacterController playerController = GetComponent<CharacterController>();

        // isGrounded ensures that the player would only move when touching the ground
        if(playerController.isGrounded)
        {
            // Input.GetAxis takes the float values from the keys
            // "Horizontal" represents the left, right, A, and D keys
            // "Vertical" represents the up, down, W, and S keys
            MoveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            // Multiply the MoveDirection by speed so that it would move faster. MoveDirection *= speed is equivalent to MoveDirection = MoveDirection * speed 
            MoveDirection *= speed;
        }

        MoveDirection.y -= gravity * Time.deltaTime;
        playerController.Move(MoveDirection * Time.deltaTime);
        
    }
}
