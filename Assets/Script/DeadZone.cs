using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object is the player
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the dead zone");

            // Player entered the dead zone, handle player death
            HandlePlayerDeath();
        }
    }

    void HandlePlayerDeath()
    {
        // Implement the logic for player death (e.g., play death animation, reduce health, etc.)

        // Load the game over scene
        SceneManager.LoadScene(SceneManager.GetSceneByName("GameOverScene").buildIndex);
    }
}
