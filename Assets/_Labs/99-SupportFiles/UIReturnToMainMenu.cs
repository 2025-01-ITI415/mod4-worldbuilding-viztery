using UnityEngine;
using UnityEngine.SceneManagement;

public class UIReturnToMainMenu : MonoBehaviour
{
    [SerializeField] private GameObject returnMenu; // Assign this in the Inspector

    private void Awake()
    {
        // Optional: hide the return menu at start
        if (returnMenu != null)
        {
            returnMenu.SetActive(false);
        }
        else
        {
            Debug.LogWarning("returnMenu is not assigned in the Inspector.");
        }
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void Update()
    {
        // Left-click hides the return menu
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (returnMenu != null)
            {
                returnMenu.SetActive(false);
            }
            else
            {
                Debug.LogWarning("returnMenu is not assigned or was destroyed.");
            }
        }

        // Equals key loads the main menu
        if (Input.GetKeyDown(KeyCode.Equals))
        {
            ReturnToMainMenu();
        }
    }
}
