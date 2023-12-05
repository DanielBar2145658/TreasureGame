using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController1 : MonoBehaviour
{
    private int collectedTreasures = 0;
    public int totalTreasures = 5; // Set this to the total number of treasures in your game

    // Call this method when the player collects a treasure
    public void CollectTreasure()
    {
        collectedTreasures++;
        Debug.Log("Collected Treasures: " + collectedTreasures);
        // Check for victory condition
        if (collectedTreasures == totalTreasures)
        {
            

            YouWin();
        }
    }

    void YouWin()
    {
        // Load the YouWinScene when the player wins
        Debug.Log("YOU WIN");
        SceneManager.LoadScene("YouWinScene");
    }
}
