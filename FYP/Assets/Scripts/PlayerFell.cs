using UnityEngine;
using System.Collections;

public class PlayerFell : MonoBehaviour 
{
    public float fadeSpeed = 1.5f;	
    public bool PlayerFallen;
	// Use this for initialization
	void Start () 
    {
        PlayerFallen = false;
	}

    void Awake()
    {
        // Set the texture so that it is the the size of the screen and covers it.
        guiTexture.pixelInset = new Rect(0f, 0f, Screen.width, Screen.height);
    }
	// Update is called once per frame
	void Update () 
    {
        //if (PlayerFallen == true)
        //{
        //    guiTexture.enabled = true;
        //    FadeToBlack();

        //    if (guiTexture.color.a >= 0.95f)
        //    {
        //        Application.LoadLevel(0);
        //    }
        //}
	}

    void OnTriggerEnter(Collider col)
     {
         if (GameObject.Find("PlayerEnteredBuilding").GetComponent<PlayerEnteredBuilding>().PlayerIsInBuilding == true)
         {
             if(col.gameObject.name ==("First Person Controller"))
             {
                 PlayerFallen = true;
             }

         }
     }

    //void FadeToBlack()
    //{
    //    // Lerp the colour of the texture between itself and black.
    //    guiTexture.color = Color.Lerp(guiTexture.color, Color.black, fadeSpeed * Time.deltaTime);
    //}
}
