using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 8f;
    public float gravity = -9.81f;
    public bool hasGliderOn;

    private CharacterController controller;
    private Transform thisTransform;
    private Vector3 velocity;
   

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        thisTransform = transform;
        hasGliderOn = false;
    }
    private void Update()
    {
       

        MoveCharacter();
        setGravity();
        ApplyGravity();
        KeepCharacterOnAxis();
    }
     private void setGravity()
    {
        if (hasGliderOn)
        {
            gravity = -3.27f;
        }
        else
        {
            gravity = -9.81f;
        }

    }
   
    private void ApplyGravity()
    {
        bool isGrounded = Physics.Raycast(transform.position, -Vector3.up, .8f);

        if( !isGrounded || velocity.y > 0)
        {
            velocity.y += gravity * Time.deltaTime;
        }
        else
        {
            velocity.y = 0;
            hasGliderOn = false;
        }

        controller.Move(velocity * Time.deltaTime);
    }


    private void MoveCharacter()
    {
        bool isGrounded = Physics.Raycast(transform.position, -Vector3.up, .8f);
        var moveInput = Input.GetAxis("Horizontal");
        var move = new Vector3(moveInput, 0, 0) * (moveSpeed * Time.deltaTime);
       


        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
        }
        else if (Input.GetButtonDown("Jump") && !hasGliderOn)
        {
            hasGliderOn = true;
            if (velocity.y < 0)
            {
                velocity.y = 0;
            }
        }
        else if(Input.GetButtonDown("Jump") && hasGliderOn) 
        {
            hasGliderOn = false;
            if (velocity.y < 0)
            {
                velocity.y = 0;
            }
        }
        controller.Move(move);
    }

    private void KeepCharacterOnAxis()
    {
        var currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }
}
