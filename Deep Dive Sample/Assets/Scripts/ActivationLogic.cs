using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationLogic : MonoBehaviour
{
    //This class is for handling the activations of certain events for showcasing different ways to use audio to achieve certain effects.

    public GameObject soundEmitter2d;
    public GameObject soundEmitter3dSoft;
    public GameObject soundEmitter3dHard;
    private ObjectMovementController movementController;

    public showcaseState currentState;
    public enum showcaseState { 
    inactiveState,
    nonAttenuation,
    attenuationSoft,
    attenuationHard
    }

    private void Start()
    {
        movementController = GetComponent<ObjectMovementController>();
    }

    private void FixedUpdate()
    {
        if(currentState == showcaseState.inactiveState && movementController.inAnimation == true)
        {
            soundEmitter2d.SetActive(false);
            soundEmitter3dSoft.SetActive(false);
            soundEmitter3dHard.SetActive(false);
        }
        if (currentState == showcaseState.nonAttenuation && movementController.inAnimation == true)
        {
            soundEmitter2d.SetActive(true);
            soundEmitter3dSoft.SetActive(false);
            soundEmitter3dHard.SetActive(false);
        }
        if (currentState == showcaseState.attenuationSoft && movementController.inAnimation == true)
        {
            soundEmitter2d.SetActive(false);
            soundEmitter3dSoft.SetActive(true);
            soundEmitter3dHard.SetActive(false);
        }
        if (currentState == showcaseState.attenuationHard && movementController.inAnimation == true)
        {
            soundEmitter2d.SetActive(false);
            soundEmitter3dSoft.SetActive(false);
            soundEmitter3dHard.SetActive(true);
        }
        if(movementController.inAnimation == false)
        {
            soundEmitter2d.SetActive(false);
            soundEmitter3dSoft.SetActive(false);
            soundEmitter3dHard.SetActive(false);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentState = showcaseState.inactiveState;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentState = showcaseState.nonAttenuation;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentState = showcaseState.attenuationSoft;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentState = showcaseState.attenuationHard;
        }
    }
}
