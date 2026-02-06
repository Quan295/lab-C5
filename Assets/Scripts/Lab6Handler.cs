using UnityEngine;

public class Lab6Handler : MonoBehaviour
{
    // Màu sắc để thay đổi khi va chạm/vào vùng trigger
    private Color originalColor;
    private MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        if (meshRenderer != null)
            originalColor = meshRenderer.material.color;
    }

    // 1. XỬ LÝ VA CHẠM (COLLISION)
    private void OnCollisionEnter(Collision collision)
    {
        // Chỉ đổi màu đỏ nếu va chạm với vật thể có Tag là "Obstacle"
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("COLLISION: Đâm vào chướng ngại vật cứng: " + collision.gameObject.name);
            if (meshRenderer != null) meshRenderer.material.color = Color.red;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (meshRenderer != null) meshRenderer.material.color = originalColor;
    }

    // 2. XỬ LÝ TRIGGER (VÙNG CẢM BIẾN)
    private void OnTriggerEnter(Collider other)
    {
        // Chỉ đổi màu xanh nếu đi xuyên qua vùng có Tag là "Goal"
        if (other.CompareTag("Goal"))
        {
            Debug.Log("TRIGGER: Đã về đích! (Vùng cảm biến): " + other.gameObject.name);
            if (meshRenderer != null) meshRenderer.material.color = Color.green;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (meshRenderer != null) meshRenderer.material.color = originalColor;
    }
}
