using UnityEngine;

abstract public class Spawner : MonoBehaviour
{
    [SerializeField] protected GameObject prefab;

    abstract public void Spawn(Vector3 pointSpawn);
}