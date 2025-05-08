using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionManager : MonoBehaviour
{
    public GameObject instructionPanel; // Assign the Panel GameObject in the Inspector

    void Start()
    {
        // Ensure the instruction panel is active at the start
        instructionPanel.SetActive(true);
    }

    void Update()
    {
        // Check for any key press
        if (instructionPanel.activeSelf && Input.anyKeyDown)
        {
            instructionPanel.SetActive(false);  // Hide the instruction panel after key press
            // Optionally, you could start the game logic here or show the start button
        }
    }
}
