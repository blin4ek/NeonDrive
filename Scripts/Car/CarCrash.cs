using UnityEngine;
using UnityEngine.Events;

public abstract class CarCrash : MonoBehaviour
{
    protected static UnityEvent Crash = new UnityEvent();

    public static void RegHandler(UnityAction handler)
    {
        Crash.AddListener(handler); 
    }

    private void OnDestroy()
    {
        Crash.RemoveAllListeners();
    }
}
