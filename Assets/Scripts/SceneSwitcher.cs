using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlaySceneSwitcher: MonoBehaviour
{
    // Reference to the button component
    public Button switchButton;

    // Scene name to switch to
    public string sceneToSwitchTo;

    void Start()
    {
        // Check if the button reference is set
        if (switchButton != null)
        {
            // Add a listener to the button's onclick event
            switchButton.onClick.AddListener(SwitchScene);
        }
        else
        {
            Debug.LogError("Switch Button is not assigned!");
        }
    }

    // Method to switch scenes
    void SwitchScene()
    {
        // Check if the scene name is not empty
        if (!string.IsNullOrEmpty(sceneToSwitchTo))
        {
            // Load the designated scene
            SceneManager.LoadScene(sceneToSwitchTo);
        }
        else
        {
            Debug.LogError("Scene to switch to is not assigned!");
        }
    }

    // Method to set the scene name to switch to
    public void SetSceneToSwitchTo(string sceneName)
    {
        sceneToSwitchTo = sceneName;
    }
}
