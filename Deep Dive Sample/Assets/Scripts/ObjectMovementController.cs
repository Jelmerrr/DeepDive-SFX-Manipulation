using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovementController : MonoBehaviour
{
    public GameObject targetObject;
    Vector3 originalPosition;
    public Vector3 openPosition = new Vector3(0, 0 ,-15);
    public float animationDuration = 10f;

    public bool isOpen = false;
    public bool inAnimation = false;

    float currentTime = 0;
    float normalizedValue;

    void Start()
    {             
        originalPosition = targetObject.transform.position;          //Store the starting position of the sidebar for return sequence
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl) && inAnimation == false)  //Detects tab placement + failsafe no animations are running
        {
            if (isOpen == false)                                    //Looks if the sidebar is opened or closed
            {
                currentTime = 0;                                    //Reset animation timer
                IEnumerator openCoroutine = PanelOpen();            //Index coroutine containing the opening animation
                StartCoroutine(openCoroutine);                      //Starts the coroutine
                isOpen = true;                                      //Updates status of sidebar
            }
            else if (isOpen == true)                                //Same as above but for closing sequence
            {
                currentTime = 0;                                    //Reset animation timer
                IEnumerator closeCoroutine = PanelClose();          //Index coroutine containing the closing animation
                StartCoroutine(closeCoroutine);                     //Starts the coroutine
                isOpen = false;                                     //Updates status of sidebar
            }
        }
        else if(Input.GetKeyDown(KeyCode.LeftControl) && inAnimation == true)
        {
            if(isOpen == false)
            {
                currentTime = animationDuration;
            }
            else if(isOpen == true)
            {
                currentTime = animationDuration;
            }
        }
    }

    IEnumerator PanelOpen()                                         //Animation for opening the sidebar
    {
        while (currentTime <= animationDuration)                    //While the time spent in animation is smaller than the duration
        {
            inAnimation = true;                                     //Update animation status
            currentTime += Time.deltaTime;                          //Update time
            normalizedValue = currentTime / animationDuration;           //Value that is used to calculate speed and progression in animation
            normalizedValue = Mathf.Sin(normalizedValue * Mathf.PI * 0.5f); //Use a sin wave in order to create a fade out effect
            targetObject.transform.position = Vector3.Lerp(originalPosition, openPosition, normalizedValue); //Use lerp to move object
            yield return null;                                      //Repeat coroutine
        }
        inAnimation = false;                                        //If animation is finished update status
    }

    IEnumerator PanelClose()                                        //Animation for closing the sidebar
    {
        while (currentTime <= animationDuration)                    //While the time spent in animation is smaller than the duration
        {
            inAnimation = true;                                     //Update animation status
            currentTime += Time.deltaTime;                          //Update time
            normalizedValue = currentTime / animationDuration;      //Value that is used to calculate speed and progression in animation
            normalizedValue = Mathf.Sin(normalizedValue * Mathf.PI * 0.5f); //Use a sin wave in order to create a fade out effect
            targetObject.transform.position = Vector3.Lerp(openPosition, originalPosition, normalizedValue); //Use lerp to move object
            yield return null;                                      //Repeat coroutine
        }
        inAnimation = false;                                        //If animation is finished update status
    }
}
