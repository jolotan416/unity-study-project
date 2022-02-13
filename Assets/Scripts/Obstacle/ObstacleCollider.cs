using UnityEngine;

public class ObstacleCollider : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == PLAYER_TAG)
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
