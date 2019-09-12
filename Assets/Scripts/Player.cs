using UnityEngine;
using System.Collections;

// This script moves the character controller forward
// and sideways based on the arrow keys.
// It also jumps when pressing space.
// Make sure to attach a character controller to the same game object.
// It is recommended that you make only one call to Move or SimpleMove per frame.

public class Player : MonoBehaviour
{
    CharacterController characterController;

    public float speed = 30.0f;
    public float jumpSpeed = 20.0f;
    public float gravity = 50.0f;
    public Host host;

    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        
    }

    void Update()
    {
        if (characterController.isGrounded)
        {
            // We are grounded, so recalculate
            // move direction directly from axes
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        // as an acceleration (ms^-2)
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);
        if (host != null)
        {
            //host.transform.position = transform.position;
            host.transform.SetPositionAndRotation(new Vector3(transform.position.x,
                transform.position.y+host.yOffset, transform.position.z), host.transform.rotation);

            if (Input.GetKey(KeyCode.E))
            {
                host = null;
                speed = 30.0f;
                jumpSpeed = 20.0f;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.GetComponent<Host>() != null)
        {
            host = other.transform.GetComponent<Host>();
            transform.position = host.transform.position;
            speed = host.speed;
            jumpSpeed = host.jumpSpeed;

        }
        
    }
}
