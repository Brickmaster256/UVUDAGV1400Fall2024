using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private CharacterController controller;
    private Transform thisTransform;
    private Vector3 movementVector = Vector3.zero;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        thisTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        MoveCharacter();
    }
    
    private void MoveCharacter()
    {
        movementVector.z = Input.GetAxis("Horizontal");
        movementVector.x = Input.GetAxis("Vertical");
        movementVector *= (moveSpeed * Time.deltaTime);
        controller.Move(movementVector);
    }


}
