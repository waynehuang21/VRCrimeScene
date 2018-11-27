using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
using UnityEngine.UI;

public class SelectMenuItem : MonoBehaviour
{

    public GameObject menuPage;
    public GameObject comparisonPage;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void HandHoverUpdate(Hand hand)
    {
        if (SteamVR_Input._default.inActions.GrabPinch.GetStateDown(hand.handType))
        {
            menuPage.SetActive(false);
            comparisonPage.SetActive(true);
        }

    }
}