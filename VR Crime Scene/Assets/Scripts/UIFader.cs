using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFader : MonoBehaviour {

    // To use UI Fader, add a CanvasGroup component to the top level menu object that could dictate the visibility of all content children,
    // make sure for menu a Panel object is used instead (so no shader but default image script inside object, see new empty Panel object)
    // Add this script on top of the top level menu and disable it. enable this script from another script on any kind of trigger then this
    // script will deal with the fade out animation. same logic can be applied for fade in.
     
    public GameObject closePopup;
    private CanvasGroup group;
    private bool isFading = false;
    private static float duration = 1f; // seconds

    // Use this for initialization
    void Start () {
        if (isFading) return; // if a fade is going on ignore duplicate call

        StartCoroutine(FadeFromTo(1f, 0f));
        closePopup.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator FadeFromTo(float from, float to)
    {
        isFading = true; // start of fading, prevent other fade in request.

        var curve = new AnimationCurve(new Keyframe[] {
            new Keyframe(0f, from),
            new Keyframe(1f, to)
        });

        float time = 0f;

        while (time < 1f)
        {
            group.alpha = curve.Evaluate(time);
            time += Time.deltaTime;
            yield return null;
        }
        //Ensure alpha is set to the t=1 value
        group.alpha = curve.Evaluate(1f);
        isFading = false;
    }
}
