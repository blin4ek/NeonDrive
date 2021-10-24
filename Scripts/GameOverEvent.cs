using UnityEngine;
using UnityEngine.Events;

public class GameOverEvent : MonoBehaviour
{
    private static UnityEvent GameOver = new UnityEvent();

    private void Start()
    {
        CarCrash.RegHandler(EndGame);
        CarStand.RegHandler(EndGame);
        Fuel.OutFuelRegHandler(EndGame);
    }

    public static void RegHandler(UnityAction handler)
    {
        GameOver.AddListener(handler);
    }

    private void EndGame()
    {
        GameOver?.Invoke();
    }

    private void OnDestroy()
    {
        GameOver.RemoveAllListeners();
    }
}
