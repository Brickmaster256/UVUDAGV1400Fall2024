using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 8f;
    public float gravity = -9.81f;

    private CharacterController controller;
    private Transform thisTransform;
    public Vector3 velocity;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        thisTransform = transform;
    }

    private void Update()
    {
        MoveCharacter();
        ApplyGravity();
        KeepCharacterOnAxis();
    }

    private void ApplyGravity()
    {
        if(!controller.isGrounded)
        {
            Debug.Log("not grounded");
            velocity.y += gravity * Time.deltaTime;
        }
        else
        {
            Debug.Log("grounded");
            velocity.y = 0f;
        }

        controller.Move(velocity * Time.deltaTime);
    }


    private void MoveCharacter()
    {
        var moveInput = Input.GetAxis("Horizontal");
        var move = new Vector3(moveInput, 0, 0) * (moveSpeed * Time.deltaTime);
        controller.Move(move);


        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            Debug.Log("Jump");
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
        }
    }

    private void KeepCharacterOnAxis()
    {
        var currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }
}
