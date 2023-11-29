using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

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
        }
        if (other.gameObject.CompareTag("Emerald"))
        {
            Destroy(other.gameObject);


            // Play the emerald pickup sound
            AudioManager.instance.PlayOneShot(FMODEvents.instance.emeraldCollected, this.transform.position);

            // Update the UI text
            //coinsText.text = "Coins: " + coins;
        }
    }
}
