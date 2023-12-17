using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer myMixer;

    public void SetMusicVolume(float sliderValue) 
    {
        myMixer.SetFloat("MusicVolume", Mathf.Log10(sliderValue) * 20); // Got this function from a tutorial video -   changes the volume based off of the decibals (very weird to work with)
    }
}
