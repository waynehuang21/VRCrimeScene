using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ToggleUI : InteractableHoverEvents
{
    public GameObject ui;
    private bool showUI = false;

    // Use this for initialization
    void Start()
    {
        ui.SetActive(showUI);
        showUI = !showUI;
    }

    // Update is called once per frame
    void OnAttachedToHand(Hand hand)
    {
        ui.SetActive(showUI);
    }

    
    void OnDetachedFromHand(Hand hand) {

    }

    //-------------------------------------------------
    private void OnHandHoverBegin()
    {
        
    }


    //-------------------------------------------------
    private void OnHandHoverEnd()
    {
        showUI = !showUI;
        ui.SetActive(showUI);
        showUI = !showUI;
    }

}
