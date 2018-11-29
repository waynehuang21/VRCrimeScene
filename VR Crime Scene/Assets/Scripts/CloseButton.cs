using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
using UnityEngine.UI;

public class CloseButton : MonoBehaviour
{

    public GameObject closePopup;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void HandHoverUpdate(Hand hand)
    {
        closePopup.SetActive(false);
    }
}