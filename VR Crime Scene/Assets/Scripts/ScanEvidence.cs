using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ScanEvidence : MonoBehaviour
{

    public GameObject evidencePopup;
    public GameObject overlayPopup;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void HandHoverUpdate(Hand hand)
    {
        if (SteamVR_Input._default.inActions.GrabPinch.GetStateDown(hand.handType))
        {
            evidencePopup.SetActive(false);
            overlayPopup.SetActive(true);
        }

    }
}