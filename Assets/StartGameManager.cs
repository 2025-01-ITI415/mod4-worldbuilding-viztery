using UnityEngine;
using UnityEngine.UI; // Required for Button component

public class UIStartMenu : MonoBehaviour
{
    [SerializeField] private GameObject startPanel;      // The panel that holds the start UI
    [SerializeField] private Button startButton;         // The actual start button

    private void Start()
    {
        // Ensure the start button is properly assigned in the Inspector
        if (startButton != null)
        {
            startButton.onClick.AddListener(OnStartButtonClicked); // Register the button click
        }
        else
        {
            Debug.LogError("Start Button is not assigned in the Inspector.");
        }

        // Optionally, you can hide the start panel initially in case it's visible by default
        if (startPanel != null)
        {
            startPanel.SetActive(true); // Ensure it’s active at the beginning
        }
        else
        {
            Debug.LogError("Start Panel is not assigned in the Inspector.");
        }
    }

    // Public method that gets called when the Start Button is clicked
    public void OnStartButtonClicked()
    {
        Debug.Log("Start button clicked!");

        if (startPanel != null)
        {
            startPanel.SetActive(false); // Hide the start panel when the game starts
        }

        // Optionally load a new scene or start gameplay immediately
        // No scene loading in this version
    }
}
