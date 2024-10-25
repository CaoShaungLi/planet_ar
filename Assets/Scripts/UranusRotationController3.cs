using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UranusRotationController : MonoBehaviour
{
    public GameObject PlanetObject;
    // Set a higher rotation speed for Uranus
    public Vector3 RotationVector = new Vector3(2f, 14.7f, 0); // X for tilt, Y for spin

    private const float UranusAxialTilt = 97.8f; // Uranus axial tilt

    private void Start()
    {
        // Set initial rotation to represent Uranus's extreme axial tilt
        PlanetObject.transform.rotation = Quaternion.Euler(UranusAxialTilt, 0, 0);
    }

    private void Update()
    {
        // Rotate the planet object around its Y-axis (and slightly on X-axis for visibility)
        PlanetObject.transform.Rotate(RotationVector * Time.deltaTime);
    }
}