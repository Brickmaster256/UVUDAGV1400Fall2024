using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;


public class PlayPauseControl : MonoBehaviour
{
    private TextMeshProUGUI textobj;
    public AudioSource audioSource;
    private void Start()
    {
        textobj = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (audioSource.isPlaying)
        {
            textobj.text = "Pause Music";
        }
        else
        {
            textobj.text = "Play Music";
        }

    }
    
}
