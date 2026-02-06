using UnityEngine;

public class ForceController : MonoBehaviour
{
    public float forceAmount = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Nhấn phím Space để đẩy vật thể về phía trước
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.forward * forceAmount, ForceMode.Impulse);
            Debug.Log("Applied Impulse Force!");
        }

        // Di chuyển bằng phím mũi tên hoặc WASD sử dụng AddForce
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * forceAmount);
    }
}
