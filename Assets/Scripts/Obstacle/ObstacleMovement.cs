using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float backwardForce = -100;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, backwardForce * Time.deltaTime);
    }
}
