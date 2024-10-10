using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopAudio : MonoBehaviour
{
    public AudioSource background;

    private void OnTriggerEnter(Collider other)
    {
        background.Stop();
    }


  }
