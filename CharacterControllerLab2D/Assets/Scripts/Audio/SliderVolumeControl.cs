using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderVolumeControl : MonoBehaviour
{
    public AudioSource bgMusicSource;
    public Slider volumeSlider;
    void Start()
    {
        volumeSlider.value = bgMusicSource.volume;
        volumeSlider.onValueChanged.AddListener(AdjustVolume);
    }

    public void AdjustVolume(float newVolume)
    {
        bgMusicSource.volume = newVolume;
    }
}
