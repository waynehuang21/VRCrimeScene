using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class HoverUI : InteractableHoverEvents {

    public GameObject ui;
    private bool showUI = false;

    // Use this for initialization
    void Start () {
        ui.SetActive(showUI);
        showUI = !showUI;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnHandHoverBegin()
    {
        ui.SetActive(showUI);
    }

    private void OnHandHoverEnd()
    {
        showUI = !showUI;
        ui.SetActive(showUI);
        showUI = !showUI;
    }
}
