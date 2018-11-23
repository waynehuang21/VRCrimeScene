using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class Popup : MonoBehaviour
{

    public GameObject popup;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void OnAttachedToHand(Hand hand)
    {
        popup.SetActive(true);
    }

    void OnDetachedFromHand(Hand hand)
    {
        popup.SetActive(false);
    }
}
