using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Musicplayer : MonoBehaviour
{
    public AudioSource AudioSource;
    private float musicVolume = 1f;
    public Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource.Play();
        musicVolume = PlayerPrefs.GetFloat("Volume");
        AudioSource.volume = musicVolume;
        volumeSlider.value = musicVolume;
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource.volume = musicVolume;
        PlayerPrefs.SetFloat("Volume", musicVolume);
    }

    public void updateVolume(float volume)
    {
        musicVolume = volume;
    }
}
