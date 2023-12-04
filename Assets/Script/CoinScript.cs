using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public string cageDoorTag = "CageDoor"; // Set this to the tag of your cage doors

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Find all game objects with the specified tag
            GameObject[] cageDoors = GameObject.FindGameObjectsWithTag(cageDoorTag);

            // Loop through all found objects and destroy them
            foreach (GameObject cageDoor in cageDoors)
            {
                Destroy(cageDoor);

            }

            // Optionally, you can destroy the coin after collecting it
            Destroy(gameObject);
        }
    }
}
