using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class PopupHandler : MonoBehaviour
{

    public GameObject evidencePopup;
    public GameObject evidenceCanvas;
    public bool notScanned = true;
    private bool flag = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void OnAttachedToHand(Hand hand)
    {
        if (notScanned)
        {
            evidencePopup.SetActive(true);
            for (int i = 0; i < evidencePopup.transform.childCount; i++)
            {
                evidencePopup.transform.GetChild(i).gameObject.SetActive(false);
            }
            evidenceCanvas.SetActive(true);
        }
    }

    void OnDetachedFromHand(Hand hand)
    {
        if (notScanned)
        {
            evidencePopup.SetActive(false);
        }
    }

    void HandHoverUpdate(Hand hand)
    {
        Throwable script = gameObject.GetComponent<Throwable>();
        if (script == null)
        {
            if (SteamVR_Input._default.inActions.GrabPinch.GetStateDown(hand.handType))
            {
                if (flag)
                {
                    if (notScanned)
                    {
                        evidencePopup.SetActive(true);
                        for (int i = 0; i < evidencePopup.transform.childCount; i++)
                        {
                            evidencePopup.transform.GetChild(i).gameObject.SetActive(false);
                        }
                        evidenceCanvas.SetActive(true);
                        flag = !flag;
                    }
                }
                else
                {
                    if (notScanned)
                    {
                        evidencePopup.SetActive(false);
                        flag = !flag;
                    }
                }
            }
        }
    }
}