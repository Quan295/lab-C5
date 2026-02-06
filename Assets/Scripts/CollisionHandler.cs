using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    // Ham nay goi khi xay ra va cham vat ly (Physical Collision)
    private void OnCollisionEnter(Collision collision)
    {
        // In ra ten vat the chung ta vua cham vao
        Debug.Log("<color=red>COLLISION!</color> Mat xac va cham voi: " + collision.gameObject.name);
    }

    // Ham nay goi khi di xuyen qua vat the co che do "Is Trigger"
    private void OnTriggerEnter(Collider other)
    {
        // In ra ten vat the chung ta vua di xuyen qua
        Debug.Log("<color=yellow>TRIGGER!</color> Da di xuyen qua vung: " + other.gameObject.name);
    }
}
