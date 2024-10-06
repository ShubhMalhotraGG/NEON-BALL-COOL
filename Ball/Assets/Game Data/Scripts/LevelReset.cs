using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReset : MonoBehaviour
{
    // This function will be called when the object collides with another object
    private void OnCollisionEnter(Collision collision)
    {
        // Reload the active scene to reset everything
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
