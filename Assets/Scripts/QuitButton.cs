using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    // Reference to the button component
    public Button quitButton;

    void Start()
    {
        // Check if the quit button reference is set
        if (quitButton != null)
        {
            // Add a listener to the button's onclick event
            quitButton.onClick.AddListener(Quit);
        }
        else
        {
            Debug.LogError("Quit Button is not assigned!");
        }
    }

    // Method to quit the game
    void Quit()
    {
        // Quit the application
        Application.Quit();
    }
}
