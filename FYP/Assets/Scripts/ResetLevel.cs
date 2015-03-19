using UnityEngine;
using System.Collections;

public class ResetLevel : MonoBehaviour 
{
    public float fadeSpeed = 1.5f;
    private bool sceneStarting = true;

	// Use this for initialization
	void Start () 
    {
	
	}

    void Awake()
    {
        // Set the texture so that it is the the size of the screen and covers it.
        guiTexture.pixelInset = new Rect(0f, 0f, Screen.width, Screen.height);
    }

	// Update is called once per frame
	void Update () 
    {
        //Debug.Log(GameObject.Find("First Person Controller").GetComponent<CharacterMotor>().movement.velocity.y);
        //if (GameObject.Find("First Person Controller").GetComponent<CharacterMotor>().movement.velocity.y <= -38)
        //{
        //    Application.LoadLevel("GlassTest");
        //}
	}

    void FadeToClear()
    {
        // Lerp the colour of the texture between itself and transparent.
        guiTexture.color = Color.Lerp(guiTexture.color, Color.clear, fadeSpeed * Time.deltaTime);
    }

    void FadeToBlack()
    {
        // Lerp the colour of the texture between itself and black.
        guiTexture.color = Color.Lerp(guiTexture.color, Color.black, fadeSpeed * Time.deltaTime);
    }

    void StartScene()
    {
        // Fade the texture to clear.
        FadeToClear();

        // If the texture is almost clear...
        if (guiTexture.color.a <= 0.05f)
        {
            // ... set the colour to clear and disable the GUITexture.
            guiTexture.color = Color.clear;
            guiTexture.enabled = false;

            // The scene is no longer starting.
            sceneStarting = false;
        }
    }
    
}
