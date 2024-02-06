// using UnityEngine;

// public class PlayerMovement : MonoBehaviour
// {
//     public float moveSpeed = 5f; // Movement speed of the player

//     private Rigidbody rb; // Reference to the Rigidbody component

//     void Start()
//     {
//         // Get reference to the Rigidbody component attached to the player GameObject
//         rb = GetComponent<Rigidbody>();
//     }

//     void Update()
//     {
//         // Get input from the player
//         float moveHorizontal = Input.GetAxis("Horizontal");
//         float moveVertical = Input.GetAxis("Vertical");

//         // Calculate movement direction based on input
//         Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

//         // Apply movement to the Rigidbody
//         rb.velocity = movement * moveSpeed;
//     }
// }

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Capsule : MonoBehaviour
// {

//     private bool jumpKeyWasPressed;
//     private float HorizontalInput;
//     private Rigidbody myRigidbody;

//     // Start is called before the first frame update
//     void Start()
//     {
//         myRigidbody = GetComponent<Rigidbody>();
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         //jump
//         if (Input.GetKeyDown(KeyCode.Space))
//         {
//             jumpKeyWasPressed = true;
//         }
//         HorizontalInput = Input.GetAxis("Horizontal");
//     }

//     private void FixedUpdate()
//     {

//         if (jumpKeyWasPressed && myRigidbody.velocity.y == 0)
//         {
//             myRigidbody.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
//             jumpKeyWasPressed = false;
//         }
//         myRigidbody.velocity = new Vector3(HorizontalInput, myRigidbody.velocity.y, 0);
//     }

// }

// using UnityEngine;

// public class PlayerMovement : MonoBehaviour
// {
//     public float moveSpeed = 5f;

//     private Rigidbody rb;

//     void Start()
//     {
//         rb = GetComponent<Rigidbody>();
//     }

//     void FixedUpdate()
//     {
//         float horizontalInput = Input.GetAxis("Horizontal");
//         float verticalInput = Input.GetAxis("Vertical");

//         Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized * moveSpeed;
//         rb.velocity = transform.TransformDirection(movement);
//     }
// }

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
