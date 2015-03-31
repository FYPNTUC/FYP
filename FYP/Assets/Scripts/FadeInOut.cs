using UnityEngine;
using System.Collections;

public class FadeInOut : MonoBehaviour
{
    public Transform BlackCubeL;
    public Transform BlackCubeR;

   public GameObject ResetLocation;
    GameObject Player;

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
        ResetLocation = GameObject.Find("ResetLocation");
        Player = GameObject.FindGameObjectWithTag("Player");
	}
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetButtonDown("cButtonStart"))
        {
            ChangeLevelFade = true;
        }

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
               //gameObject.transform.position = ResetLocation.transform.position;
               if (ChangeLevelFade == true)
               {
                   //ChangingLevel = true;
                   //Application.LoadLevel(levelToLoad);
                   Player.transform.position = ResetLocation.transform.position;
                   BlackCubeL.renderer.material.color = EndColor;
                   
                   if (BlackCubeL.renderer.material.color == EndColor)
                   {
                       FadeToDarkTimer = 0;
                       FadeToLightTimer += Time.deltaTime;
                       BlackCubeL.renderer.material.color = Color.Lerp(EndColor, StartColor, FadeToLightTimer);
                       BlackCubeR.renderer.material.color = Color.Lerp(EndColor, StartColor, FadeToLightTimer);
                       GameObject.Find("PlayerFallTrigger").GetComponent<PlayerFell>().PlayerFallen = false;
                       ChangeLevelFade = false;   
                   }
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
