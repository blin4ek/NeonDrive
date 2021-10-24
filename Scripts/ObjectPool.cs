using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        PoolObjects.ReturnItem(gameObject);
    }
}
