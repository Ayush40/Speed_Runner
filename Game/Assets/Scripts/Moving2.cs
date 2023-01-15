using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving2 : MonoBehaviour
{
    public float speed = 1.0f; // The speed of the movement

    void Update()
    {
        // Move the object to the right
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
