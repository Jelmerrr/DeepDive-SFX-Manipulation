using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationLogic : MonoBehaviour
{
    //This class is for handling the activations of certain events for showcasing different ways to use audio to achieve certain effects.

    public GameObject soundEmitter2d;
    public GameObject soundEmitter3dSoft;
    public GameObject soundEmitter3dHard;

    public showcaseState currentState;
    public enum showcaseState { 
    inactiveState,
    nonAttenuation,
    attenuationSoft,
    attenuationHard
    }
}
