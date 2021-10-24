using System.Collections;
using UnityEngine;

public class TimeDilation : MonoBehaviour
{
    private void OnEnable()
    {
        GameOverEvent.RegHandler(Slowdown);
    }

    private void OnDisable()
    {
        Time.timeScale = 1;
    }

    private void Slowdown()
    {
        StartCoroutine(Dilation());
    }

    IEnumerator Dilation()
    {
        float reductionSpeed = 5f;

        while (Time.timeScale > 0.1)
        {
            Time.timeScale = Mathf.Lerp(Time.timeScale, 0, reductionSpeed * Time.deltaTime);
            yield return null;
        }

        Time.timeScale = 0;
    }
}