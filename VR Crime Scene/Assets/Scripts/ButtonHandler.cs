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

    public GameObject uiLayer2p2t1;
    public GameObject uiLayer2p2t2;
    public GameObject uiLayer2p2t3;
    public GameObject uiLayer2p2t4;
    public GameObject uiLayer2p2t5;

    public GameObject uiLayer2p3t1;
    public GameObject uiLayer2p3t2;
    public GameObject uiLayer2p3t3;
    public GameObject uiLayer2p3t4;
    public GameObject uiLayer2p3t5;

    public Hand hand;

    // Use this for initialization
    void Start()
    {
        hand = gameObject.GetComponent<Hand>();
        uiLayer1p1.SetActive(false);
        uiLayer1p2.SetActive(false);
        uiLayer1p3.SetActive(false);
        uiLayer2p1t1.SetActive(false);
        uiLayer2p1t2.SetActive(false);
        uiLayer2p1t3.SetActive(false);
        uiLayer2p1t4.SetActive(false);
        uiLayer2p1t5.SetActive(false);

        uiLayer2p2t1.SetActive(false);
        uiLayer2p2t2.SetActive(false);
        uiLayer2p2t3.SetActive(false);
        uiLayer2p2t4.SetActive(false);
        uiLayer2p2t5.SetActive(false);

        uiLayer2p3t1.SetActive(false);
        uiLayer2p3t2.SetActive(false);
        uiLayer2p3t3.SetActive(false);
        uiLayer2p3t4.SetActive(false);
        uiLayer2p3t5.SetActive(false);
    }

    // Update is called once per frame
    void Update()

    {

        if (SteamVR_Input._default.inActions.Teleport.GetStateDown(hand.handType))
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

                }
                else if (uiLayer2p2t1.activeSelf)
                {
                    uiLayer2p2t1.SetActive(false);
                    uiLayer2p2t2.SetActive(false);
                    uiLayer2p2t3.SetActive(false);
                    uiLayer2p2t4.SetActive(false);
                    uiLayer2p2t5.SetActive(false);

                }
                else if (uiLayer2p3t1.activeSelf)
                {
                    uiLayer2p3t1.SetActive(false);
                    uiLayer2p3t2.SetActive(false);
                    uiLayer2p3t3.SetActive(false);
                    uiLayer2p3t4.SetActive(false);
                    uiLayer2p3t5.SetActive(false);

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

