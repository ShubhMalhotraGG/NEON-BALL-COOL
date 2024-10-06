using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GATE : MonoBehaviour
{
    public GameObject DOOR;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Destroy(DOOR);
            Destroy(gameObject);
        }
    }
}
