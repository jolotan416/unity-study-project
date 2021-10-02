using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float backwardForce = -100;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, backwardForce);
    }
}
