using UnityEngine;

public class WaterInteraction : MonoBehaviour
{
    public float speedDecreaseAmount = 2f; // Amount by which the player's speed decreases in water

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMovement playerMovement = other.GetComponent<PlayerMovement>();
            if (playerMovement != null)
            {
                playerMovement.DecreaseSpeed(speedDecreaseAmount);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMovement playerMovement = other.GetComponent<PlayerMovement>();
            if (playerMovement != null)
            {
                playerMovement.ResetSpeed();
            }
        }
    }
}

