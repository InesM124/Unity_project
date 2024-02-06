using UnityEngine;

public class SphereCoin : MonoBehaviour
{
    public float disappearDelay = 1f; // Delay before the coin disappears
    public float respawnTime = 5f; // Time in seconds before the coin respawns
    public float rotationSpeed = 50f; // Rotation speed of the coin

    private void Start()
    {
        // Rotate the coin on its local Y-axis
        RotateCoin();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Coin collected by the player
            gameObject.SetActive(false); // Disable the coin with a delay
            Invoke("RespawnCoin", respawnTime); // Schedule the coin to respawn after a delay
        }
    }

    private void RespawnCoin()
    {
        gameObject.SetActive(true); // Enable the coin
        RotateCoin(); // Rotate the coin again
    }

    private void RotateCoin()
    {
        // Rotate the coin on its local Y-axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
