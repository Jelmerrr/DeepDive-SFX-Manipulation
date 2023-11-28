using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CamSwitcher : MonoBehaviour
{
    public Camera camMain;
    public Camera camSpecial;

    public Canvas soundGuide;


    void Start()
    {
        camMain.enabled = true;
        camSpecial.enabled = false;

        soundGuide.enabled = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            camMain.enabled = !camMain.enabled;
            camSpecial.enabled = !camSpecial.enabled;
            soundGuide.enabled = !soundGuide.enabled;
        }
    }
}
