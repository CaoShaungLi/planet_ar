using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaturnRotationController : MonoBehaviour
{
    public GameObject PlanetObject;
    // Set a higher rotation speed for Saturn
    public Vector3 RotationVector = new Vector3(0.01f, 2.0f, 0); // X for tilt, Y for spin

    private const float SaturnAxialTilt = 26.7f; // Saturn axial tilt

    private void Start()
    {
        // Set initial rotation to represent Saturn's axial tilt
        PlanetObject.transform.rotation = Quaternion.Euler(SaturnAxialTilt, 0, 0);
    }

    private void Update()
    {
        // Rotate the planet object around its Y-axis (and slightly on X-axis for visibility)
        PlanetObject.transform.Rotate(RotationVector * Time.deltaTime);
    }
}