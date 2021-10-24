using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    [SerializeField] private Transform car;
    private Transform transformCamera;   

    private float offset = 5;

    private void Start()
    {
        transformCamera = GetComponent<Transform>();
    }

    private void Update()
    {
        transformCamera.position = new Vector2(car.position.x + offset, transformCamera.position.y);
    }
}