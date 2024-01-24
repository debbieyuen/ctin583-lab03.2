using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
/*
Question: Player Movement
You are creating a single-player game for mobile devices, websites, and VR headsets.
Your first-person character is a GameObject on the (0,0,0) x, y, z axis in a 3D (URP) scene.
Write a C# script using Unity’s new Input Manager System that moves the player’s
position up, down, left, and right. The character should follow the laws of gravity
and simulate physics with RigidBody.
*/

public class PlayerController : MonoBehaviour
{
    [Header("General Setup Settings")]
    [SerializeField] private InputAction movement;
    [Tooltip("How fast player moves up and down based upon player input")][SerializeField] float controlSpeed = 30f;
    [Tooltip("How far player moves horizontally")][SerializeField] float xRange = 10f;
    [Tooltip("How far player moves vertically")][SerializeField] float zRange = 10f;

    [Header("Screen position based tuning")]
    [SerializeField] float positionPitchFactor = -2f;
    [SerializeField] float positionYawFactor = 2f;

    [Header("Player input based tuning")]
    [SerializeField] float controlPitchFactor = 10f;
    [SerializeField] float controlRollFactor = -20f;
    float xThrow;
    float zThrow;

    private void OnEnable()
    {
        movement.Enable();
    }

    private void OnDisable()
    {
        movement.Disable();
    }

    void Update()
    {
        ProcessTranslation();
        ProcessRotation();
    }

    private void ProcessRotation()
    {
        // Calculate the player's pitch, yaw, and roll
        float pitchDueToPosition = transform.localPosition.z * positionPitchFactor;
        float pitchDueToControlThrow = zThrow * controlPitchFactor;
        float pitch = pitchDueToPosition + pitchDueToControlThrow;

        float yaw = transform.localPosition.x * positionYawFactor;

    }

    private void ProcessTranslation()
    {
        // Read the player input
        xThrow = movement.ReadValue<Vector2>().x;
        zThrow = movement.ReadValue<Vector2>().y;

        // Calculate the player's position
        float xOffset = xThrow * Time.deltaTime * controlSpeed;
        float zOffset = zThrow * Time.deltaTime * controlSpeed;
        float rawXPos = transform.localPosition.x + xOffset;
        float rawZPos = transform.localPosition.z + zOffset;

        // Limit the player's position
        float clampedXPos = Mathf.Clamp(rawXPos, -xRange, xRange);
        float clampedZPos = Mathf.Clamp(rawZPos, -zRange, zRange);

        // Update the player's position
        transform.localPosition = new Vector3(clampedXPos, transform.localPosition.y, clampedZPos);
    }
}
