using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercuryRotationController : MonoBehaviour
{
    public GameObject PlanetObject;
    // Set a higher rotation speed for Mercury
    public Vector3 RotationVector = new Vector3(0, 2.0f, 0); 

    private const float MercuryAxialTilt = 0.034f; // Mercury axial tilt

    private void Start()
    {
        // Set initial rotation to represent Mercury's axial tilt
        PlanetObject.transform.rotation = Quaternion.Euler(MercuryAxialTilt, 0, 0);
    }

    private void Update()
    {
        // Rotate the planet object around its Y-axis (and slightly on X-axis for visibility)
        PlanetObject.transform.Rotate(RotationVector * Time.deltaTime);
    }
}