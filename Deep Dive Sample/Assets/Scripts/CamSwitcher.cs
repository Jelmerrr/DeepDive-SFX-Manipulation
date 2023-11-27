using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CamSwitcher : MonoBehaviour
{
    public Camera camMain;
    public Camera camSpecial;
    public Camera camMenu;

    public Canvas soundGuide;

    private Camera activeCam;

    void Start()
    {
        camMain.enabled = true;
        camSpecial.enabled = false;
        camMenu.enabled = false;

        soundGuide.enabled = true;

        activeCam = camMain;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            camMain.enabled = !camMain.enabled;
            camSpecial.enabled = !camSpecial.enabled;
            soundGuide.enabled = !soundGuide.enabled;

            if(activeCam == camMain)
            {
                activeCam = camSpecial;
            }
            else if (activeCam == camSpecial)
            {
                activeCam = camMain;
            }
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (camMenu.enabled == false)
            {
                camMain.enabled = false;
                camSpecial.enabled = false;
                soundGuide.enabled = false;
            }
            if(camMenu.enabled == true)
            {
                if(activeCam == camMain)
                {
                    camMain.enabled = true;
                    soundGuide.enabled = true;
                }
                if(activeCam == camSpecial)
                {
                    camSpecial.enabled = true;
                }
            }
            camMenu.enabled = !camMenu.enabled;         
        }
    }
}
