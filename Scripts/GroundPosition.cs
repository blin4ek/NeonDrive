using UnityEngine;

public class GroundPosition : MonoBehaviour
{
    private Camera cam;
    private Transform ground;

    private void Start()
    {
        cam = Camera.main;
        ground = GetComponent<Transform>();
    }

    private void Update()
    {
        ground.position = new Vector3(cam.transform.position.x, ground.position.y, ground.position.z);
    }
}