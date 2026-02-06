using UnityEngine;

public class PlayerMovement3D : MonoBehaviour
{
    [Header("Movement Settings")]
    public float forceAmount = 15f; 
    
    private Rigidbody rb;
    private Vector3 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.z = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        Vector3 force = new Vector3(moveInput.x, 0, moveInput.z) * forceAmount;
        rb.AddForce(force);
    }
}
