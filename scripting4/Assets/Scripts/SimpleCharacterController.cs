using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 8f;
    public float gravity = -9.81f;
    
    private CharacterController controller;
    private Vector3 velocity;
    private Transform thisTransform;
    //private Vector3 movementVector = Vector3.zero;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        thisTransform = transform;
    }

    private void Update()
    {
        //MoveCharacter();
        ApplyGravity();
        KeepCharacterOnXAxis();
        MoveCharacter();
        
    }

    private void MoveCharacter()
    {
        var moveInput = Input.GetAxis("Horizontal");
        var move = new Vector3(moveInput, 0f, 0f) * (moveSpeed * Time.deltaTime);
        controller.Move(move);

        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
        }    
        //movementVector.x = Input.GetAxis("Horizontal");
        //movementVector *= (moveSpeed * Time.deltaTime);
        //controller.Move(movementVector);
    }

    private void ApplyGravity()
    {
        if (!controller.isGrounded)
        {
            velocity.y *= gravity * Time.deltaTime;
        }
        else
        {
            velocity.y = 0f;
        }
        
        controller.Move(velocity * Time.deltaTime);
    }
    private void KeepCharacterOnXAxis()
    {
        // Use cached transform reference and optimize vector creation
        var currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }
}