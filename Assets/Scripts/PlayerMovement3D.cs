using UnityEngine;

public class PlayerMovement3D : MonoBehaviour
{
    [Header("Movement Settings")]
    public float forceAmount = 15f; // Sức mạnh của lực đẩy
    
    private Rigidbody rb;
    private Vector3 moveInput;

    void Start()
    {
        // Lấy Component Rigidbody
        rb = GetComponent<Rigidbody>();
        
        // Đảm bảo Rigidbody không bị xoay mất kiểm soát khi va chạm
        rb.freezeRotation = true;
    }

    void Update()
    {
        // Lấy input từ phím mũi tên hoặc WASD
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.z = Input.GetAxis("Vertical");

        // Nhấn Space để dùng lực đẩy tức thời (Impulse) - giúp thấy rõ tác động của AddForce
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
            Debug.Log("Jump! (Applied Impulse Force)");
        }
    }

    void FixedUpdate()
    {
        // Tính toán hướng lực
        Vector3 force = new Vector3(moveInput.x, 0, moveInput.z) * forceAmount;
        
        // THỰC HIỆN ĐẨY: Sử dụng AddForce để di chuyển vật thể
        // Đây là yêu cầu trọng tâm của Lab 5
        rb.AddForce(force);
    }
}
