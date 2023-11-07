using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitcher : MonoBehaviour
{
    public Camera camMain;
    public Camera camSpecial;

    void Start()
    {
        camMain.enabled = true;
        camSpecial.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            camMain.enabled = !camMain.enabled;
            camSpecial.enabled = !camSpecial.enabled;
        }
    }
}
