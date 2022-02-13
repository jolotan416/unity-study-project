using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float sidewaysForce = 500f;
    [SerializeField] float fallRestartPosition = -1f;

    private float playerInput = 0f;

    void FixedUpdate()
    {
        float computedSidewaysForce = (playerInput < 0 ? -sidewaysForce :
            (playerInput > 0 ? sidewaysForce : 0)) * Time.deltaTime;
        rb.AddForce(computedSidewaysForce, 0, 0, ForceMode.VelocityChange);

        if (rb.position.y <= fallRestartPosition)
        {
            FindObjectOfType<GameManager>().TriggerRestart();
        }
    }

    void Update()
    {
        playerInput = Input.GetAxis("Horizontal");
    }
}
