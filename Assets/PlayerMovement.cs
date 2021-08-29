using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    private bool willMoveRight = false;
    private bool willMoveLeft = false;

    void FixedUpdate()
    {
        float computedSidewaysForce = (willMoveLeft ? -sidewaysForce :
            (willMoveRight ? sidewaysForce : 0)) * Time.deltaTime;
        rb.AddForce(computedSidewaysForce, 0, forwardForce * Time.deltaTime);
    }

    void Update()
    {
        willMoveLeft = Input.GetKey(KeyCode.A);
        willMoveRight = Input.GetKey(KeyCode.D);
    }
}