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

    // Update is called once per frame
    void HandAttachedUpdate(Hand hand)
    {
        if (SteamVR_Input._default.inActions.GrabPinch.GetStateDown(hand.handType))
        {
            roomLight.SetActive(lightStatus);
            flashLight.SetActive(!lightStatus);
            hiddenObjects.SetActive(!lightStatus);
            lightStatus = !lightStatus;
        }

    }
}
