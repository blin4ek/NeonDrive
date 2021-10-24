using UnityEngine;
using UnityEngine.Events;

public class CarBreakingBarrier : MonoBehaviour
{
    private static UnityEvent BreakingBarrier = new UnityEvent();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 12) { BreakingBarrier?.Invoke(); collision.gameObject.SetActive(false); }
    }

    public static void RegHandler(UnityAction handler)
    {
        BreakingBarrier.AddListener(handler);
    }

    private void OnDestroy()
    {
        BreakingBarrier.RemoveAllListeners();
    }
}