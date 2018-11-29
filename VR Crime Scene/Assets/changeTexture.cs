using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeTexture : MonoBehaviour {

    RawImage rawImage;
    public Texture texture2;
    public bool isScanned = false;


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        rawImage = GetComponent<RawImage>();
        if (isScanned)
        {
            rawImage.texture = texture2;
        }
    }
}
