using UnityEngine;

[RequireComponent(typeof(SurfaceEffector2D))]
public class ConveyorController : MonoBehaviour
{
    [Header("Conveyor Settings")]
    public float speed = 5f;
    public bool reverseDirection = false;

    private SurfaceEffector2D surfaceEffector;

    void Start()
    {
        surfaceEffector = GetComponent<SurfaceEffector2D>();
        UpdateEffector();
    }

    void Update()
    {
        // Allow updating speed in Real-time from Inspector or simple logic
        UpdateEffector();
    }

    void UpdateEffector()
    {
        if (surfaceEffector != null)
        {
            surfaceEffector.speed = reverseDirection ? -speed : speed;
        }
    }
}
