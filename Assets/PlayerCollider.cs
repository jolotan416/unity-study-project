using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private static readonly string OBSTACLE_TAG = "Obstacle";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == OBSTACLE_TAG)
        {
            playerMovement.enabled = false;
        }
    }
}
