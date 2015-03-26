using UnityEngine;
using System.Collections;

public class FadeInOut : MonoBehaviour
{
    public Transform BlackCubeL;
    public Transform BlackCubeR;

    public bool fade;
    public bool ChangeLevelFade;
    public string levelToLoad;

    private float FadeToDarkTimer;
    private float FadeToLightTimer;

    private Color StartColor;
    private Color EndColor;

    private bool ChangingLevel;

	// Use this for initialization
	void Start ()
    {
        StartColor = new Color(0,0,0,0);
        EndColor = new Color(0, 0, 0, 1);

        FadeToDarkTimer = 0;
        FadeToLightTimer = 0;
        fade = false;
        ChangingLevel = false;
	}
	 
	// Update is called once per frame
	void Update ()
    {
        if (fade == true || ChangeLevelFade == true)
        {
            if (BlackCubeL.renderer.material.color == StartColor)
            {
                FadeToLightTimer = 0;
            }

            FadeToDarkTimer += Time.deltaTime;
            BlackCubeL.renderer.material.color = Color.Lerp(StartColor, EndColor, FadeToDarkTimer);
            BlackCubeR.renderer.material.color = Color.Lerp(StartColor, EndColor, FadeToDarkTimer);

            if (BlackCubeL.renderer.material.color == EndColor && ChangingLevel == false)
            {
                if (ChangeLevelFade == true)
                {
                    ChangingLevel = true;
                    Application.LoadLevel(levelToLoad);
                }
            }
        }

        else
        {
            if (BlackCubeL.renderer.material.color == EndColor)
            {
                FadeToDarkTimer = 0;
            }

            FadeToLightTimer += Time.deltaTime;
            BlackCubeL.renderer.material.color = Color.Lerp(EndColor, StartColor, FadeToLightTimer);
            BlackCubeR.renderer.material.color = Color.Lerp(EndColor, StartColor, FadeToLightTimer);
        }
	}
}
