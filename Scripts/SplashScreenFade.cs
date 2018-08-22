using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplashScreenFade : MonoBehaviour {

    public float fadeInTime;

    private Image fadePanel;
    private Color currentColor = Color.black;

    void Start()
    {
        fadePanel = GetComponent<Image>();
    }

    void Update()
    {
        if (Time.timeSinceLevelLoad < fadeInTime)
        {
            float alphaChange = Time.deltaTime / fadeInTime;
            currentColor.a -= alphaChange;
            fadePanel.color = currentColor;
        }
        else
        {
            float alphaChange = Time.deltaTime * fadeInTime;
            currentColor.a += alphaChange;
            fadePanel.color = currentColor;
        }
    }
}
