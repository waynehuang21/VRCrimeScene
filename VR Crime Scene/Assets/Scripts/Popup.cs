using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class Popup : MonoBehaviour
{

    public GameObject evidencePopup;
    public bool notScanned = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void OnAttachedToHand(Hand hand)
    {
        if (notScanned) {
            evidencePopup.SetActive(true);
        }
    }

    void OnDetachedFromHand(Hand hand)
    {
        if (notScanned) {
            evidencePopup.SetActive(false);
        }
    }
}
