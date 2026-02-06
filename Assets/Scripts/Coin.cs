using UnityEngine;

public class Coin : MonoBehaviour
{
    // Script này dùng cho vật phẩm (Trigger)
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Đã ăn được xu! (Trigger hoạt động)");
            Destroy(gameObject); // Biến mất khi bị ăn
        }
    }
}
