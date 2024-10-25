using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotationController : MonoBehaviour
{
    public GameObject PlanetObject;
    public Vector3 RotationVector = new Vector3(0, 15f, 0); 

    private void Start()
    {
        // Optionally set an initial rotation if needed
        PlanetObject.transform.rotation = Quaternion.Euler(23.5f, 0, 0); // Earth's axial tilt
    }

    private void Update()
    {
        // Rotate the planet object around its X and Y axes
        PlanetObject.transform.Rotate(RotationVector * Time.deltaTime);
    }
}