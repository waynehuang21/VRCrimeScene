using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ToggleLights : MonoBehaviour
{

    public GameObject roomLight;
    public GameObject flashLight;
    public GameObject hiddenObjects;
    private bool lightStatus = false;

    // Use this for initialization
    void Start()
    {

    }

    void OnAttachedToHand(Hand hand)
    {
        roomLight.SetActive(lightStatus);
        flashLight.SetActive(!lightStatus);
        hiddenObjects.SetActive(!lightStatus);
        lightStatus = !lightStatus;
    }

    void OnDetachedFromHand(Hand hand)
    {
        roomLight.SetActive(lightStatus);
        flashLight.SetActive(!lightStatus);
        hiddenObjects.SetActive(!lightStatus);
        lightStatus = !lightStatus;
    }
}
