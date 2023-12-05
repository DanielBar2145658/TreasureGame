using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemCollector : MonoBehaviour
{
    public string cageDoorTag = "CageDoor";
    int coins = 0;
    [SerializeField] Text coinsText;
    [SerializeField] ItemManagerUI managerUI;
    [SerializeField] AudioClip coinPickupSound;  // Add this line
    private AudioSource audioSource;  // Add this line

    private int collectedTreasures = 0;
    public int totalTreasures = 5;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();  // Add this line
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;

            // Play the coin pickup sound
            AudioManager.instance.PlayOneShot(FMODEvents.instance.coinCollected, this.transform.position);

            // Update the UI text
            //coinsText.text = "Coins: " + coins;

            GameObject cageDoor = GameObject.FindGameObjectWithTag("CageDoor"); // Assuming "CageDoor" is the tag of your cage door

            if (cageDoor != null)
            {
                Destroy(cageDoor);
            }
            else
            {
                Debug.LogError("Cage door not found!");
            }

        }
        if (other.gameObject.CompareTag("Treasure"))
        {


            Item item = other.gameObject.GetComponent<Item>();
            if (item.ID == "Book")
                managerUI.DisableItemUI(0);
            else if (item.ID == "Diamond")
                managerUI.DisableItemUI(1);
            else if (item.ID == "Emerald")
                managerUI.DisableItemUI(2);
            else if (item.ID == "Gold")
                managerUI.DisableItemUI(3);
            // Play the emerald pickup sound
            AudioManager.instance.PlayOneShot(FMODEvents.instance.emeraldCollected, this.transform.position);

            Destroy(other.gameObject);
            // Update the UI text
            //coinsText.text = "Coins: " + coins;

            collectedTreasures++;

            // Check for victory condition
            if (collectedTreasures == totalTreasures)
            {
                YouWin();
            }

            // Destroy the collected treasure
            Destroy(item.gameObject);
        }
    }

    void YouWin()
    {
        // Load the YouWinScene when the player wins
        SceneManager.LoadScene("YouWinScene");
    }
}
