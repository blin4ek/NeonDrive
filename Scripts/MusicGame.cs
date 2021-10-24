using System.Collections;
using UnityEngine;

public class MusicGame : MonoBehaviour
{
    [SerializeField] private AudioClip[] clips;

    private static MusicGame instance = null;

    private AudioSource music;

    private void Start()
    {
        music = GetComponent<AudioSource>();
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        StartCoroutine(PlayMusic());
    }

    IEnumerator PlayMusic()
    {
        yield return null;
        for (int i = 0; i < clips.Length; i++)
        {
            music.clip = clips[i];
            music.Play();
            while (music.isPlaying)
            {
                yield return null;
            }
        }
    }
}