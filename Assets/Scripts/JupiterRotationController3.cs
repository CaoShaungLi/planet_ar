using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JupiterRotationController : MonoBehaviour
{
    public GameObject PlanetObject;
    // Set a higher rotation speed for Jupiter
    public Vector3 RotationVector = new Vector3(2f, 6.25f, 0); // X for tilt, Y for spin

    private const float JupiterAxialTilt = 3.1f; // Jupiter axial tilt

    private void Start()
    {
        // Set initial rotation to represent Jupiter's axial tilt
        PlanetObject.transform.rotation = Quaternion.Euler(JupiterAxialTilt, 0, 0);
    }

    private void Update()
    {
        // Rotate the planet object around its X and Y axes
        PlanetObject.transform.Rotate(RotationVector * Time.deltaTime);
    }
}