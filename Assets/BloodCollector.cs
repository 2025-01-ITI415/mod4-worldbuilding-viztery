using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class VampireGame : MonoBehaviour
{
    public int collectedBags = 0;
    public int requiredBags = 10;

    public GameObject winMessage;
    public TextMeshProUGUI returnToCoffinText;
    public GameObject youDiedMessage;

    public Button playAgainButtonWin;
    public Button playAgainButtonLose;

    // Reference to the TextMeshPro UI element for the blood bag counter
    public TextMeshProUGUI bloodBagCounterText;

    private void Start()
    {
        // Ensure UI elements are hidden at the start
        if (returnToCoffinText != null)
            returnToCoffinText.gameObject.SetActive(false);

        if (winMessage != null)
            winMessage.SetActive(false);

        if (youDiedMessage != null)
            youDiedMessage.SetActive(false);

        if (playAgainButtonWin != null)
            playAgainButtonWin.gameObject.SetActive(false);

        if (playAgainButtonLose != null)
            playAgainButtonLose.gameObject.SetActive(false);

        // Initialize the blood bag counter text
        UpdateBloodBagCounter();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BloodBag"))
        {
            collectedBags++;
            Destroy(other.gameObject);
            Debug.Log("Collected: " + collectedBags);

            // Update the blood bag counter text
            UpdateBloodBagCounter();

            if (collectedBags >= requiredBags && returnToCoffinText != null)
                returnToCoffinText.gameObject.SetActive(true);
        }
        else if (other.CompareTag("Garlic"))
        {
            Debug.Log("Touched garlic! You died.");
            if (youDiedMessage != null)
                youDiedMessage.SetActive(true);

            if (playAgainButtonLose != null)
                playAgainButtonLose.gameObject.SetActive(true);

            // Optionally, disable player controls here
        }
        else if (other.CompareTag("FinishZone"))
        {
            if (collectedBags >= requiredBags)
            {
                Debug.Log("You win!");
                if (winMessage != null)
                    winMessage.SetActive(true);

                if (returnToCoffinText != null)
                    returnToCoffinText.gameObject.SetActive(false);

                if (playAgainButtonWin != null)
                    playAgainButtonWin.gameObject.SetActive(true);
            }
            else
            {
                Debug.Log("Collect all blood bags before returning to the coffin.");
            }
        }
    }

    // Method to update the blood bag counter text
    private void UpdateBloodBagCounter()
    {
        if (bloodBagCounterText != null)
            bloodBagCounterText.text = $"Blood Bags: {collectedBags}/{requiredBags}";
    }

    // Method to restart the game
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
