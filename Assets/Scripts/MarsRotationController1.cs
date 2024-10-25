using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarsRotationController : MonoBehaviour
{
    public GameObject PlanetObject;
    // Mars rotates approximately 15.5 degrees per hour (360 degrees / 24.6 hours)
    public Vector3 RotationVector = new Vector3(15.5f / 3600f, 0, 0); // Degrees per second
    private const float MarsAxialTilt = 25.2f;

    private void Start()
    {
        // Set initial rotation to represent Mars' axial tilt
        PlanetObject.transform.rotation = Quaternion.Euler(MarsAxialTilt, 0, 0);
    }

    private void Update()
    {
        // Rotate the planet object around its X-axis (tilt) and Y-axis (spin)
        PlanetObject.transform.Rotate(RotationVector * Time.deltaTime);
    }
}