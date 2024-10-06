using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCloseGame : MonoBehaviour
{
    // Duration in seconds before the game closes
    public float closeAfterSeconds = 5f;

    void Start()
    {
        // Start the coroutine to close the game
        StartCoroutine(CloseGameAfterDelay());
    }

    private IEnumerator CloseGameAfterDelay()
    {
        // Wait for the specified duration
        yield return new WaitForSeconds(closeAfterSeconds);

        // Close the application
        Application.Quit();

        // If running in the editor, stop playing
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}