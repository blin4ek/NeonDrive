using UnityEngine;
using UnityEngine.Advertisements;

public class ADS : MonoBehaviour
{
    private string gameId = "3990337";
    private static int counter = 0;

    void Start()
    {
        Advertisement.Initialize(gameId, false);
    }

    public static void ShowAds()
    {
        counter++;
        if (counter == 3) { Advertisement.Show("video"); counter = 0; }
    }
}
