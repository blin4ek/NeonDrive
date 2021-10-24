using UnityEngine;

public class FollowBackground : MonoBehaviour
{
    private Material materail;
    private Vector2 offset;

    [SerializeField] private Transform car;

    [SerializeField] private float reductionSpeedHorizontal;
    [SerializeField] private float reductionSpeedVertical;

    void Start()
    {
        materail = GetComponent<SpriteRenderer>().material;
    }

    private void Update()
    {
        offset.x = car.position.x / reductionSpeedHorizontal;
        offset.y = car.position.y / reductionSpeedVertical;
        materail.mainTextureOffset = Vector2.Lerp(materail.mainTextureOffset, offset, Time.deltaTime); 
    }
}