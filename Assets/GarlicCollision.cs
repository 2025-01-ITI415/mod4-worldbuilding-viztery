using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarlicCollision : MonoBehaviour

{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Handle collision with player
            Debug.Log("Player touched the garlic!");
            // Additional logic here
        }
    }
}


