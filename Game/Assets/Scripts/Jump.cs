using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float speed = 1.0f; // The speed of the movement
    public float amplitude = 5.0f; // The distance the object moves up and down

    void Update()
    {
        // Use the sin function to create an up and down movement
        float yPos = amplitude * Mathf.Sin(Time.time * speed);

        // Update the object's position
        transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
    }
}
