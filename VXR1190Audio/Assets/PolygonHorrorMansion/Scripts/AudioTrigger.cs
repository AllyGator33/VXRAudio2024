using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public GameObject targetObject;  // Reference to the GameObject with the AudioSource
    public AudioSource audioSource;
    public AudioClip audioClip;
    public bool soundPlayed = false;


  
    void OnTriggerEnter(Collider other)
    {
        if (!soundPlayed)
        {
            audioSource.PlayOneShot(audioClip);

            soundPlayed = true;
        }

    }
}
  
   





