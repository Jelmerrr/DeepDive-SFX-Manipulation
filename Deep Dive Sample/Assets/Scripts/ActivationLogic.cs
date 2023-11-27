using UnityEngine;

public class ActivationLogic : MonoBehaviour
{
    //This class is for handling the activations of certain events for showcasing different ways to use audio to achieve certain effects.

    public GameObject soundEmitter2d;
    public GameObject soundEmitter3dSoft;
    public GameObject soundEmitter3dHard;
    public GameObject soundEmitter3dReverb;
    public GameObject soundemitter3dDelay;
    public GameObject soundEmitter3dDelayReverb;
    private ObjectMovementController movementController;

    public showcaseState currentState;
    public enum showcaseState { 
    inactiveState,
    nonAttenuation,
    attenuationSoft,
    attenuationHard,
    attenuationReverb,
    attenuationDelay,
    attenuationDelayReverb
    }

    private void Start()
    {
        movementController = GetComponent<ObjectMovementController>();
        DisableEmitters();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha0))
        {
            StateUpdate(showcaseState.inactiveState);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            StateUpdate(showcaseState.nonAttenuation);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            StateUpdate(showcaseState.attenuationHard);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            StateUpdate(showcaseState.attenuationSoft);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            StateUpdate(showcaseState.attenuationReverb);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            StateUpdate(showcaseState.attenuationDelay);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            StateUpdate(showcaseState.attenuationDelayReverb);
        }
    }

    private void StateUpdate(showcaseState currentState)
    {
        DisableEmitters();
        if(movementController.inAnimation == true)
        {
            soundEmitter2d.SetActive(currentState == showcaseState.nonAttenuation);
            soundEmitter3dSoft.SetActive(currentState == showcaseState.attenuationSoft);
            soundEmitter3dHard.SetActive(currentState == showcaseState.attenuationHard);
            soundEmitter3dReverb.SetActive(currentState == showcaseState.attenuationReverb);
            soundemitter3dDelay.SetActive(currentState == showcaseState.attenuationDelay);
            soundEmitter3dDelayReverb.SetActive(currentState == showcaseState.attenuationDelayReverb);
        }
    }

    private void DisableEmitters()
    {
        soundEmitter2d.SetActive(false);
        soundEmitter3dSoft.SetActive(false);
        soundEmitter3dHard.SetActive(false);
        soundEmitter3dReverb.SetActive(false);
        soundemitter3dDelay.SetActive(false);
        soundEmitter3dDelayReverb.SetActive(false);
    }
}
