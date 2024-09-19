using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        HandleAnimations();
    }

    private void HandleAnimations()
    {
        if(Input.GetAxis("Horizontal") !=0)
        {
            animator.SetTrigger("Run");
        }
        else
        {
            animator.SetTrigger("Idle");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("FallTrigger");
        }

        if(Input.GetKeyDown(KeyCode.H))
        {
            animator.SetTrigger("HitTrigger");
        }

        

        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("DoubleJumpTrigger");
        }

        if(Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("WallJump");
        }
    }
}
