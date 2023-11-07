using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationLogic : MonoBehaviour
{
    //This class is for handling the activations of certain events for showcasing different ways to use audio to achieve certain effects.

    public GameObject soundEmitter;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log(soundEmitter.transform.position.z);
            soundEmitter.transform.position = new Vector3(0,0,-15);
        }
    }
}
