using UnityEngine;

public class Moving : MonoBehaviour
{
    public float speed = 1.0f; // The speed of the movement
    public float amplitude = 5.0f; // The distance the object moves left and right

    void Update()
    {
        // Use the sin function to create a left and right movement
        float xPos = amplitude * Mathf.Sin(Time.time * speed);

        // Update the object's position
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
    }
}
