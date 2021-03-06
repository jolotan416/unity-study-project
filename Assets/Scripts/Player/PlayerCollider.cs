using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    private static readonly string OBSTACLE_TAG = "Obstacle";
    private static readonly string GROUND_TAG = "Ground";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == OBSTACLE_TAG)
        {
            FindObjectOfType<GameManager>().TriggerRestart();
        }
    }
}
