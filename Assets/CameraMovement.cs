using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 cameraOffset;

    void Update()
    {
        transform.position = cameraOffset + playerTransform.position;
    }
}
