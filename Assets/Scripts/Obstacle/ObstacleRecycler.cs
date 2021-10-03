using UnityEngine;

public class ObstacleRecycler : MonoBehaviour
{
    public GameObject recycledGameObject;

    private const string GROUND_TAG = "Ground";

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == GROUND_TAG)
        {
            Destroy(recycledGameObject);
        }
    }
}
