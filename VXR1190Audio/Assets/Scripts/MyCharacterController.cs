using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    // Movement speed for the character
    public float moveSpeed = 5f;

    // Mouse sensitivity for looking around
    public float mouseSensitivity = 2f;

    // Reference to the camera for looking around
    public Camera playerCamera;

    // Vertical rotation limit for the camera
    public float verticalRotationLimit = 80f;

    private float verticalRotation = 0f; // Track vertical rotation

    private void Start()
    {
        // Lock the cursor to the center of the screen
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        // Handle character movement
        MoveCharacter();

        // Handle mouse look (camera rotation)
        LookAround();
    }

    private void MoveCharacter()
    {
        // Get input for movement
        float horizontalInput = Input.GetAxis("Horizontal"); // A/D or Left/Right arrows
        float verticalInput = Input.GetAxis("Vertical");     // W/S or Up/Down arrows

        // Create a movement vector based on input
        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput);

        // Make the character move in the direction it is facing
        moveDirection = transform.TransformDirection(moveDirection); // Transform to world space

        // Normalize to prevent faster diagonal movement
        moveDirection.Normalize();

        // Move the character
        Vector3 move = moveDirection * moveSpeed * Time.deltaTime;

        // Add up/down movement with E and Q keys
        if (Input.GetKey(KeyCode.E))
        {
            move += Vector3.up * moveSpeed * Time.deltaTime; // Move up
        }
        if (Input.GetKey(KeyCode.Q))
        {
            move += Vector3.down * moveSpeed * Time.deltaTime; // Move down
        }

        // Apply the movement to the character
        transform.Translate(move, Space.World); // Use Space.World to move in global coordinates
    }

    private void LookAround()
    {
        // Get mouse input for looking around
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Rotate the character horizontally
        transform.Rotate(0, mouseX * mouseSensitivity, 0);

        // Update vertical rotation and clamp it
        verticalRotation -= mouseY * mouseSensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation, -verticalRotationLimit, verticalRotationLimit);

        // Apply the vertical rotation to the camera
        if (playerCamera != null)
        {
            playerCamera.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);
        }
    }
}


