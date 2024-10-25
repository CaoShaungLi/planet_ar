using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRotationController : MonoBehaviour
{
    public GameObject MoonObject;
    // Set a higher rotation speed for the Moon
    public Vector3 RotationVector = new Vector3(0, 0.5f, 0);

    private const float MoonAxialTilt = 1.5f; // Moon axial tilt

    private void Start()
    {
        // Set initial rotation to represent the Moon's axial tilt
        MoonObject.transform.rotation = Quaternion.Euler(MoonAxialTilt, 0, 0);
    }

    private void Update()
    {
        // Rotate the Moon object around its Y-axis (and slightly on X-axis for visibility)
        MoonObject.transform.Rotate(RotationVector * Time.deltaTime);
    }
}