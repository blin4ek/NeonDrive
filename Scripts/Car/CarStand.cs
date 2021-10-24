using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CarStand : MonoBehaviour
{
    private static UnityEvent CarStop = new UnityEvent();

    private float prevX;
    private bool isGameOver = false;

    void Start()
    {
        StartCoroutine(CheckPosition());
    }

    public static void RegHandler(UnityAction handler)
    {
        CarStop.AddListener(handler);
    }

    IEnumerator CheckPosition()
    {
        while (!isGameOver)
        {
            prevX = transform.position.x;
            yield return new WaitForSeconds(1.5f);
            if (prevX >= transform.position.x) { isGameOver = true; CarStop?.Invoke(); }
        }
    }

    private void OnDestroy()
    {
        CarStop.RemoveAllListeners();
    }
}