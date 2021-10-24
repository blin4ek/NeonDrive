using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    [SerializeField] private int delay = 0;

    private void OnBecameInvisible()
    {
        Destroy(gameObject, delay);
    }
}
