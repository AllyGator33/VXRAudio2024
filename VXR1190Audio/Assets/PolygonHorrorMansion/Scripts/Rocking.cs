using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocking : MonoBehaviour
{
    // Variables to control the speed and angle of the rocking
    public float angle = 20f;       // Max angle of rotation
    public float speed = 2f;        // Speed of rocking

    private float startRotationZ;

    void Start()
    {
        // Record the initial Z rotation to keep it relative
        startRotationZ = transform.eulerAngles.z;
    }

    void Update()
    {
        // Calculate the new Z angle using a sine wave for smooth oscillation
        float zRotation = startRotationZ + Mathf.Sin(Time.time * speed) * angle;
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, zRotation);
    }
}
