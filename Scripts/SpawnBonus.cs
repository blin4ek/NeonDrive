using UnityEngine;

public class SpawnBonus : Spawner
{
    private float minY = -0.5f;
    private float maxY = 2.5f;
    private int chance = 75;

    public override void Spawn(Vector3 pointSpawn)
    {
        if (Random.Range(0, 100) > chance)
        {
            pointSpawn.y += Random.Range(minY, maxY);
            Instantiate(prefab, pointSpawn, Quaternion.identity);
        }    
    }
}