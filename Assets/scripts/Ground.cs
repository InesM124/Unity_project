using UnityEngine;

public class GroundDetector : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, Mathf.Infinity))
        {
            // Adjust the player's position to stay on the ground
            rb.MovePosition(hit.point + Vector3.up * 0.5f); // Assuming the player's height is 1 unit
        }
    }
}
