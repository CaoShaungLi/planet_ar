using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeptuneRotationController : MonoBehaviour
{
    public GameObject PlanetObject;
    // Set a higher rotation speed for better visibility
    public Vector3 RotationVector = new Vector3(0, -0.1f, 0); // Rotate around Y-axis (clockwise)

    private const float NeptuneAxialTilt = 28.3f; // Neptune axial tilt

    private void Start()
    {
        // Set initial rotation to represent Neptune's axial tilt
        PlanetObject.transform.rotation = Quaternion.Euler(NeptuneAxialTilt, 0, 0);
    }

    private void Update()
    {
        // Rotate the planet object around the Y-axis
        PlanetObject.transform.Rotate(RotationVector * Time.deltaTime);
    }
}