using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class jumpscare : MonoBehaviour
{
    public Image popupImage; // Assign this in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Adjust the tag as needed
        {
            StartCoroutine(ShowImageForTime(1f)); // Show for 1 second
        }
    }

    private IEnumerator ShowImageForTime(float time)
    {
        popupImage.gameObject.SetActive(true); // Activate the image
        yield return new WaitForSeconds(time); // Wait for the specified time
        popupImage.gameObject.SetActive(false); // Deactivate the image
    }
}