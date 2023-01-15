using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed = 1.0f; // The speed of the rotation

    void Update()
    {
        // Rotate the object around the y-axis
        transform.Rotate(0, rotationSpeed, 0);
    }
}
