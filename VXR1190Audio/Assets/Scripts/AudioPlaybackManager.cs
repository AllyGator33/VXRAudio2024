using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlaybackManager: MonoBehaviour

{
    public AudioSource audioPlayer;
    public AudioSource stopAudio;

    //custom function
    public void PlayAudio(AudioClip clip)
    {

        audioPlayer.PlayOneShot(clip);

    }


        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}