using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ButtonHandler : MonoBehaviour
{
    public GameObject uiLayer1p1;
    public GameObject uiLayer1p2;
    public GameObject uiLayer1p3;
    public GameObject uiLayer2p1t1;
    public GameObject uiLayer2p1t2;
    public GameObject uiLayer2p1t3;
    public GameObject uiLayer2p1t4;
    public GameObject uiLayer2p1t5;
    public GameObject uiLayer2p1t6;
    public GameObject uiLayer2p1t7;
    public GameObject uiLayer2p1t8;
    public GameObject uiLayer2p1t9;
    public Hand hand;

    // Use this for initialization
    void Start()
    {
        hand = gameObject.GetComponent<Hand>();
        uiLayer1p1.SetActive(false);
        uiLayer1p2.SetActive(false);
        uiLayer1p3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (SteamVR_Input._default.inActions.GrabPinch.GetStateDown(hand.handType))
        {
            if (uiLayer1p1.activeSelf)
            {
                uiLayer1p1.SetActive(false);
                uiLayer1p2.SetActive(false);
                uiLayer1p3.SetActive(false);

            } else {
                if (uiLayer2p1t1.activeSelf)
                {
                    uiLayer2p1t1.SetActive(false);
                    uiLayer2p1t2.SetActive(false);
                    uiLayer2p1t3.SetActive(false);
                    uiLayer2p1t4.SetActive(false);
                    uiLayer2p1t5.SetActive(false);
                    uiLayer2p1t6.SetActive(false);
                    uiLayer2p1t7.SetActive(false);
                    uiLayer2p1t8.SetActive(false);
                    uiLayer2p1t9.SetActive(false);
                }
                    
                uiLayer1p1.SetActive(true);
                uiLayer1p2.SetActive(true);
                uiLayer1p3.SetActive(true);
            }

        }

        if (SteamVR_Input._default.inActions.GrabPinch.GetStateUp(hand.handType))
        {

        }

    }


}

