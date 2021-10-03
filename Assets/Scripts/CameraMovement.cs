using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform cameraTransform;
    public Transform playerTransform;
    public float cameraHeight = 2;

    void FixedUpdate()
    {
        cameraTransform.position = new Vector3(playerTransform.position.x,
            playerTransform.position.y + cameraHeight, cameraTransform.position.z);
    }
}
