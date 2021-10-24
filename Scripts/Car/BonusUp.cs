using UnityEngine;
using UnityEngine.Events;

public class BonusUp : MonoBehaviour
{
    private static UnityEvent PickedUp = new UnityEvent();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7) { PickedUp.Invoke(); Destroy(collision.gameObject); }
    }

    public static void RegHandler(UnityAction handler)
    {
        PickedUp.AddListener(handler);
    }
}