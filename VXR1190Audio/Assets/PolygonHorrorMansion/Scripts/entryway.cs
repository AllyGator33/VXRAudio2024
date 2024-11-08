using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class entryway : MonoBehaviour
{
    [SerializeField] Animator doorL;
    
    [SerializeField] private string chooseAnimation = "animationName";
  

    public AudioSource sound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            doorL.Play(chooseAnimation);
            sound.Play();
        }
    }

}



