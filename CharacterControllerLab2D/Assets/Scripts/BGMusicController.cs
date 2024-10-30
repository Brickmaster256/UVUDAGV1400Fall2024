using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusicController : MonoBehaviour
{
    public AudioSource BGMusicSource;

    public void ToggleMusic()
    {
        if (BGMusicSource.isPlaying)
        {
            BGMusicSource.Pause();
        }
        else
        {
            BGMusicSource.Play();
        }
    }

}
