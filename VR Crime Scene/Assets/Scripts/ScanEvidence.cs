using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
using UnityEngine.UI;

public class ScanEvidence : MonoBehaviour
{

    public GameObject evidencePopup;
    public GameObject collectedPopup;
    public GameObject evidence;
    public GameObject overlayPopup;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void HandHoverUpdate(Hand hand)
    {
        evidencePopup.SetActive(false);
        collectedPopup.SetActive(true);
        evidence.GetComponent<PopupHandler>().notScanned = false;
        overlayPopup.SetActive(true);
    }
}