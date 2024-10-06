using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public float JumpForce = 8;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;

    public bool CanJump = true;
    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }

    public void Jump()
    {
        if (CanJump)
        {
            CanJump = false;
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
        
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            CanJump = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        CanJump = false;
    }
}