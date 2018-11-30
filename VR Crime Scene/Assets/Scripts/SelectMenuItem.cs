using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
using UnityEngine.UI;

public class SelectMenuItem : MonoBehaviour
{

    public GameObject menuPage;
    public GameObject comparisonPage;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void OnHandHoverBegin(Hand hand)
    {
        menuPage.SetActive(false);
        comparisonPage.SetActive(true);

    }
}