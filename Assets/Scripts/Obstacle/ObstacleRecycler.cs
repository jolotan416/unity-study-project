using UnityEngine;

public class ObstacleRecycler : MonoBehaviour
{
    [SerializeField] GameObject recycledGameObject;

    private const string GROUND_TAG = "Ground";

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == GROUND_TAG)
        {
            Destroy(recycledGameObject);
        }
    }
}
