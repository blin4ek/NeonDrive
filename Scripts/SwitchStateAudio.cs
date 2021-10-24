using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SwitchStateAudio : MonoBehaviour
{
    private Toggle toggleAudio;
    [SerializeField] private AudioMixerGroup music;

    private void Start()
    {
        toggleAudio = GetComponent<Toggle>();
        toggleAudio.isOn = PlayerPrefs.GetInt(PlayerPrefsKeys.STATE_AUDIO) == 1;
        SwitchState(toggleAudio.isOn);
    }

    public void SwitchState(bool state)
    {
        if (!state)
        {
            music.audioMixer.SetFloat("Volume", -80);
        }
        else
        {
            music.audioMixer.SetFloat("Volume", 0);
        }
        PlayerPrefs.SetInt(PlayerPrefsKeys.STATE_AUDIO, state ? 1 : 0);
    }
}