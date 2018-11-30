using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class MenuHandler : MonoBehaviour {

    private Hand hand;
    private bool flag = true;
    public GameObject menu;

	// Use this for initialization
	void Start () {
        hand = gameObject.GetComponent<Hand>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SteamVR_Input._default.inActions.Teleport.GetStateDown(hand.handType))
        {
            menu.SetActive(flag);
            flag = !flag;
        }
    }
}
