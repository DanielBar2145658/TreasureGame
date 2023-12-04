using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public string cageDoorTag = "CageDoor";
    int coins = 0;
    [SerializeField] Text coinsText;
    [SerializeField] AudioClip coinPickupSound;  // Add this line
    private AudioSource audioSource;  // Add this line

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
            Destroy(other.gameObject);


            // Play the emerald pickup sound
            AudioManager.instance.PlayOneShot(FMODEvents.instance.emeraldCollected, this.transform.position);

            // Update the UI text
            //coinsText.text = "Coins: " + coins;
        }
    }
}
