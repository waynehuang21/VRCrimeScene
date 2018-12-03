using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
using UnityEngine.UI;

public class CloseButton : MonoBehaviour
{
    //Added a script file to be activated by close button

    //public GameObject closePopup;
    public UIFader uiFader;   // take out this line if not work

    // Use this for initialization
    void Start()
    {
        uiFader = GetComponent<UIFader>(); // take out this line if not work
    }

    // Update is called once per frame
    void OnHandHoverBegin(Hand hand)
    {
        //closePopup.SetActive(false);
        uiFader.enabled = true; // take out this line if not work
    }
}