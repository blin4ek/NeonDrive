using UnityEngine;

public class SpawnBarrier : Spawner
{
    [SerializeField] private PoolObjects pool;
   
    public override void Spawn(Vector3 pointSpawn)
    {
        GameObject tempObject = pool.GetFreeItem();
        tempObject.transform.position = pointSpawn;
        tempObject.SetActive(true);
    }
}