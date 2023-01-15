using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving1 : MonoBehaviour
{
    public float speed = 1.0f; // The speed of the movement

    void Update()
    {
        // Move the object to the left
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
