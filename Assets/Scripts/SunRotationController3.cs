using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotationController : MonoBehaviour
{
    public GameObject SunObject;
    // Set a higher rotation speed for the Sun
    public Vector3 RotationVector = new Vector3(0.01f, 1.0f, 0); // X for tilt, Y for spin

    private const float SunAxialTilt = 7.25f; // Sun axial tilt

    private void Start()
    {
        // Set initial rotation to represent the Sun's axial tilt
        SunObject.transform.rotation = Quaternion.Euler(SunAxialTilt, 0, 0);
    }

    private void Update()
    {
        // Rotate the Sun object around its Y-axis (and slightly on X-axis for visibility)
        SunObject.transform.Rotate(RotationVector * Time.deltaTime);
    }
}