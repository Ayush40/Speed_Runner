using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacleCube")
        {
            movement.enabled = false;
            FindObjectOfType<AudioManager>().Play("PlayerDeath");
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
