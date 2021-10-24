using UnityEngine;

public class FollowNet : MonoBehaviour
{
    [SerializeField] private SpriteRenderer[] sprites;

    private Material[] materials = new Material[4];

    private Vector2 offset = Vector2.zero;
    [SerializeField] private float speed;

    void Start()
    {
        for (int i = 0; i < sprites.Length; i++)
        {
            materials[i] = sprites[i].material;
        }
    }

    void Update()
    {
        offset.x += speed * Time.deltaTime;
        foreach (var item in materials)
        {
            item.mainTextureOffset = Vector2.Lerp(item.mainTextureOffset, offset, Time.deltaTime);
        }
    }
}
