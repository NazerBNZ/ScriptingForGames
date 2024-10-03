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
        // handles running and idling
        if (Input.GetAxis("Horizontal") != 0)
        {
            animator.SetTrigger("Run");
        }
        else
        {
            animator.SetTrigger("Idle");
        }
        
        // handles jumping
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("Jump");
        }
        
        // double jump
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("DoubleJump");
        }
        
        // hit
        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetTrigger("Hit");
        }
        
        // fall
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("Fall");
        }
        
        // wall jumps
        if (Input.GetKeyDown(KeyCode.Z))
        {
            animator.SetTrigger("WallJump");
        }
    }
} 
