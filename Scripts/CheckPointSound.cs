using UnityEngine;

public class CheckPointSound : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        CarBreakingBarrier.RegHandler(PlaySound);
    }

    private void PlaySound()
    {
        audioSource.Play();
    }
}
