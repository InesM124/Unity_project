using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement speed of the player

    private Rigidbody rb; // Reference to the Rigidbody component

    void Start()
    {
        // Get reference to the Rigidbody component attached to the player GameObject
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Get input from the player
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate movement direction based on input
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Apply movement to the Rigidbody
        rb.velocity = movement * moveSpeed;
    }
}
