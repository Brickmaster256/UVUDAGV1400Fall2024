using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float gravity = -9.81f;
    [SerializeField] private float jumpForce = 8f;
    [SerializeField] private float floorDistance = .8f;

    private CharacterController controller;
    private Transform thisTransform;
    private Vector3 movementVector = Vector3.zero;
    public Vector3 velocity;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        thisTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        MoveCharacter();
        ApplyGravity();
    }
    private void ApplyGravity()
    {
        bool isGrounded = Physics.Raycast(transform.position, -Vector3.up, floorDistance);

        if (!isGrounded || velocity.y > 0)
        {
            velocity.y += gravity * Time.deltaTime;  
        }
        else
        {
            velocity.y = 0;
        }
        controller.Move(velocity * Time.deltaTime);
    }
    
    private void MoveCharacter()
    {
        bool isGrounded = Physics.Raycast(transform.position, -Vector3.up, floorDistance);
        movementVector.z = Input.GetAxis("Horizontal");
        movementVector.x = Input.GetAxis("Vertical");
        movementVector *= (moveSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);

        }

        controller.Move(movementVector);

        
    }


}
