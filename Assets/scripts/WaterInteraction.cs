using UnityEngine;

public class WaterInteraction : MonoBehaviour
{
    public float speedDecreaseAmount = 2f; // Amount by which the player's speed decreases in water
    
    private void OnTriggerEnter(Collider other)
    { Debug.Log("test.");
        if (other.CompareTag("Player"))
        {
            // Get the PlayerMovement script from the player GameObject
            Debug.Log("Player entered water.");
            PlayerMovement playerMovement = other.GetComponent<PlayerMovement>();

            // If the PlayerMovement script is found, decrease the player's speed
            if (playerMovement != null)
            {
                playerMovement.DecreaseSpeed(speedDecreaseAmount);
            }
        }
    }
}
