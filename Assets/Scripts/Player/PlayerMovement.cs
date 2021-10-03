using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float sidewaysForce = 500f;
    public float fallRestartPosition = -1f;

    private bool willMoveRight = false;
    private bool willMoveLeft = false;

    void FixedUpdate()
    {
        float computedSidewaysForce = (willMoveLeft ? -sidewaysForce :
            (willMoveRight ? sidewaysForce : 0)) * Time.deltaTime;
        rb.AddForce(computedSidewaysForce, 0, 0, ForceMode.VelocityChange);

        if (rb.position.y <= fallRestartPosition)
        {
            FindObjectOfType<GameManager>().TriggerRestart();
        }
    }

    void Update()
    {
        willMoveLeft = Input.GetKey(KeyCode.A);
        willMoveRight = Input.GetKey(KeyCode.D);
    }
}
