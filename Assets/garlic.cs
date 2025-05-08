using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GarlicHazard : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("garlic"))
        {
            Debug.Log("Touched garlic! Game over.");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // reloads current scene
        }
    }
}
