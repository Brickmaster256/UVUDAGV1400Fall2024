using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusicController : MonoBehaviour
{
    public AudioSource BGMusicSource;

    public void ToggleMusic()
    {
        Debug.Log("Click!");
        if (BGMusicSource.isPlaying)
        {
            BGMusicSource.Pause();
            Debug.Log("Paused!");
        }
        else
        {
            BGMusicSource.Play();
            Debug.Log("Playing!");
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            ToggleMusic();
        }
    }

}
