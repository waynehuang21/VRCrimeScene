using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;


public class MenuCollide : MonoBehaviour {
    public GameObject uiLayer1p1;
    public GameObject uiLayer1p2;
    public GameObject uiLayer1p3;

    public GameObject uiLayer2p1t1;
    public GameObject uiLayer2p1t2;
    public GameObject uiLayer2p1t3;
    public GameObject uiLayer2p1t4;
    public GameObject uiLayer2p1t5;


    private bool showUI = false;
    //public Hand hand;

    // Use this for initialization
    void Start () {

        uiLayer2p1t1.SetActive(false);
        uiLayer2p1t2.SetActive(false);
        uiLayer2p1t3.SetActive(false);
        uiLayer2p1t4.SetActive(false);
        uiLayer2p1t5.SetActive(false);


    }
	
	// Update is called once per frame
	void Update () {

    }

    private void OnHandHoverStart()
    {
        //showUI = !showUI;
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "rightController")
        {
            uiLayer1p1.SetActive(false);
            uiLayer1p2.SetActive(false);
            uiLayer1p3.SetActive(false);

            uiLayer2p1t1.SetActive(true);
            uiLayer2p1t2.SetActive(true);
            uiLayer2p1t3.SetActive(true);
            uiLayer2p1t4.SetActive(true);
            uiLayer2p1t5.SetActive(true);


        }

    }

}
