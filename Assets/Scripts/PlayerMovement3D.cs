using UnityEngine;

public class PlayerMovement3D : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;
    private Vector3 moveInput;

    void Start()
    {
        // Get the 3D Rigidbody
        rb = GetComponent<Rigidbody>();
        
        // Freeze rotation so the player doesn't tip over when colliding
        rb.freezeRotation = true;
    }

    void Update()
    {
        // Get input from WASD or Arrow keys
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.z = Input.GetAxisRaw("Vertical"); // Moving on X and Z axis in 3D
    }

    void FixedUpdate()
    {
        // Move the player using Rigidbody for proper 3D physics collisions
        Vector3 moveVelocity = moveInput.normalized * moveSpeed;
        rb.linearVelocity = new Vector3(moveVelocity.x, rb.linearVelocity.y, moveVelocity.z);
    }
}
