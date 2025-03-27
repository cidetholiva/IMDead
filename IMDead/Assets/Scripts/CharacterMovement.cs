using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float gravity = -9.81f;
    public float verticalVelocity = 0f;

    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = transform.right * moveX + transform.forward * moveZ;

        // Apply gravity
        if (controller.isGrounded && verticalVelocity < 0)
        {
            verticalVelocity = -2f; // Small downward force to stay grounded
        }
        else
        {
            verticalVelocity += gravity * Time.deltaTime;
        }

        move.y = verticalVelocity;

        controller.Move(move * moveSpeed * Time.deltaTime);
    }
}

