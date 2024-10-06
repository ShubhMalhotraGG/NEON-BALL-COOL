using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CREDITS : MonoBehaviour
{
    public GameObject MMcanvas;
    public GameObject CreditsCanvas;
    public GameObject Lie;
    public GameObject Truth;
    public void Back()
    {
        MMcanvas.SetActive(true);
        CreditsCanvas.SetActive(false);
    }

    public void RevealTruth()
    {
        Truth.SetActive(true);
        Lie.SetActive(false);
    }
}
