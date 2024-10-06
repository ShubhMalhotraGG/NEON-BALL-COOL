using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Rotation speed for each axis
    public float rotationSpeedX = 0f;
    public float rotationSpeedY = 0f;
    public float rotationSpeedZ = 0f;

    // Update is called once per frame
    void Update()
    {
        // Create a rotation vector based on the speeds
        Vector3 rotationVector = new Vector3(rotationSpeedX, rotationSpeedY, rotationSpeedZ);

        // Apply the rotation to the object
        transform.Rotate(rotationVector * Time.deltaTime);
    }
}
