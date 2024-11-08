using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAudio : MonoBehaviour
{
    
    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component from this GameObject
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        // Check if the audio source is playing, then stop it
        if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}

