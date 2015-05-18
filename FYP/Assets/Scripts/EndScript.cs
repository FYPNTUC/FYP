using UnityEngine;
using System.Collections;

public class EndScript : MonoBehaviour 
{
    GameObject Player;
    bool CantJump;
    float Timer;
	// Use this for initialization
	void Start () 
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        CantJump = false;
        Timer = 0.6f;
	}
	
	//Update is called once per frame
	void Update () 
    {
        if (CantJump == true)
        {
            Player.GetComponent<OVRPlayerController>().JumpForce = 0;//was 0.3
            if (Player.GetComponent<CharacterController>().isGrounded == false)
            {
                Timer -= Time.deltaTime;
                //print(Timer);
                if (Timer <= 0)
                {
                    Player.GetComponent<FadeInOut>().ChangeLevelFade = true;
                    //print("Changed");
                }
            }

            if (Player.GetComponent<CharacterController>().isGrounded == true)
            {
                Timer = 0.6f;
            }
        }
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //Player.GetComponent<FadeInOut>().fade = true;
            if (gameObject.name == "End")
            {
                Player.GetComponent<FadeInOut>().ResetLocation = GameObject.Find("ResetLocation11");
                GameObject.FindGameObjectWithTag("CraneC").GetComponent<CraneCheck3>().IsCrane3 = false;
                CantJump = true;

            }

            if (gameObject.name == "End2")
            {
                Player.GetComponent<FadeInOut>().ResetLocation = GameObject.Find("ResetLocation12");
            }

            if (gameObject.name == "End3")
            {
                Player.GetComponent<FadeInOut>().ResetLocation = GameObject.Find("ResetLocation13");
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
        }
          
    }
}
