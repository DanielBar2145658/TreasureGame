using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float fallThreshold = -10f; // Adjust this value based on your game's requirements

    private void Update()
    {
        // Check if the player is falling based on vertical velocity
        if (GetComponent<Rigidbody>().velocity.y < fallThreshold)
        {
            // Player is falling, so call a method to handle death or perform any other necessary actions
            PlayerFall();
        }

        // Alternatively, check if the player's Y position is below a certain threshold
        if (transform.position.y < fallThreshold)
        {
            PlayerFall();
        }
    }

    private void PlayerFall()
    {
        // Handle player death or any other actions when falling
        Debug.Log("Player fell and died");

        SceneManager.LoadScene("GameOverScene");
        // You can add code here to respawn the player, show a game over screen, etc.
    }
}
