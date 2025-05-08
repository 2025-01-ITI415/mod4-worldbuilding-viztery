using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BloodBagBehavior : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Assuming your player is tagged as "Player"
        {
            // Code for when the player collects the blood bag
            // You can update a collection counter or destroy the bag
            Debug.Log("Blood bag collected!");
            Destroy(gameObject); // Destroys the blood bag when collected
        }
    }
}
