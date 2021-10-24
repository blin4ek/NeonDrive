using System.Collections;
using UnityEngine;

public class PointSpawn : MonoBehaviour
{
    [SerializeField] private Spawner[] spawners;

    private Transform transformObject;

    private Vector2 pointSpawn;

    private void Start()
    {
        transformObject = GetComponent<Transform>();
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        float maxY = 1.5f;
        float minY = -2f;     

        while (true)
        { 
            if (transformObject.position.x - pointSpawn.x > Random.Range(6, 10))
            {
                pointSpawn = new Vector2(transformObject.position.x, transformObject.position.y + Random.Range(minY, maxY));
                foreach (var spawner in spawners)
                {
                    spawner.Spawn(pointSpawn);
                }
            }
            yield return null;
        }
    }
}
