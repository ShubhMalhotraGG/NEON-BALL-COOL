using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Assign these in the Inspector
    public GameObject mainMenuCanvas;
    public GameObject creditsCanvas;

    public void StartGame()
    {
        // Load the next level in the build index
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }

    public void ShowCredits()
    {
        // Disable the main menu canvas and enable the credits canvas
        mainMenuCanvas.SetActive(false);
        creditsCanvas.SetActive(true);
    }

    public void QuitGame()
    {
        // Quit the game
#if UNITY_EDITOR
        // If in the editor, stop play mode
        UnityEditor.EditorApplication.isPlaying = false;
#else
            // Quit the application
            Application.Quit();
#endif
    }

    public void BackToMainMenu()
    {
        // Enable the main menu canvas and disable the credits canvas
        creditsCanvas.SetActive(false);
        mainMenuCanvas.SetActive(true);
    }
}
