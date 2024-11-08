using UnityEngine;
using UnityEngine.Audio;

public class OneWayAudioTrigger : MonoBehaviour
{
    public AudioMixerSnapshot Outside;  // Snapshot for outside audio
    public AudioMixerSnapshot Inside;   // Snapshot for inside audio
    public float transitionTime = 1.0f;         // Time to transition between snapshots
    private Vector3 triggerCenter;              // Center of the trigger to detect direction

    void Start()
    {
        // Calculate the center of the collider
        triggerCenter = GetComponent<Collider>().bounds.center;
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the collider belongs to the player by checking for a unique component
        if (other.GetComponent<CharacterController>() != null)  // Replace with your player's unique component
        {
            // Determine if the player is entering from outside or inside
            if (other.transform.position.z < triggerCenter.z)
            {
                // Player is entering from outside, transition to inside audio
                Inside.TransitionTo(2);
                Debug.Log("test");
            }
            else
            {
                // Player is exiting to outside, transition to outside audio
                Outside.TransitionTo(2);
                Debug.Log("gogo");
            }
        }
    }
}
