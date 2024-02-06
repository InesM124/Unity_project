using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Initial movement speed of the player
    private float currentSpeed; // Current movement speed of the player

    private void Start()
    {
        currentSpeed = moveSpeed;
    }

    public void DecreaseSpeed(float amount)
    {
        // Decrease the player's speed
        Debug.Log("Decreasing speed by: " + amount);
        currentSpeed -= amount;
    }

    private void FixedUpdate()
    {
        // Apply movement with the current speed
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized * currentSpeed;
        GetComponent<Rigidbody>().velocity = transform.TransformDirection(movement);
    }
    public void ResetSpeed()
    {
    currentSpeed = moveSpeed; // Reset speed to its original value
    }

}
