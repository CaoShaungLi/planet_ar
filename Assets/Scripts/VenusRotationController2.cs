using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    public GameObject PlanetObject;
    // Set a higher rotation speed for better visibility
    public Vector3 RotationVector = new Vector3(0, -1.0f, 0); // Rotate around Y-axis (clockwise)

    private const float VenusAxialTilt = 177.4f; // Venus axial tilt

    private void Start()
    {
        // Set initial rotation to represent Venus' axial tilt
        PlanetObject.transform.rotation = Quaternion.Euler(VenusAxialTilt, 0, 0);
    }

    private void Update()
    {
        // Rotate the planet object around the Y-axis
        PlanetObject.transform.Rotate(RotationVector * Time.deltaTime);
    }
}