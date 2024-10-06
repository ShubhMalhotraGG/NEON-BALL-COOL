using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSceneOnCollision : MonoBehaviour
{
    // Update this with the name or index of the next scene in the build settings
    public string nextSceneName;

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object has the tag "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
            // Get the current active scene's build index
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            // Load the next scene based on the build index
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
    }
}
