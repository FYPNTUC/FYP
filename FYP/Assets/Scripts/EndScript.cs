using UnityEngine;
using System.Collections;

public class EndScript : MonoBehaviour 
{
    GameObject Player;
    bool CantJump;
    float Timer;
    GameObject PlayerModel;
    GameObject CraneA;
    GameObject CraneB;
    GameObject CraneC;

	// Use this for initialization
	void Start () 
    {
        CraneA = GameObject.FindGameObjectWithTag("CraneA");
        CraneB = GameObject.FindGameObjectWithTag("CraneB");
        CraneC = GameObject.FindGameObjectWithTag("CraneC");
        PlayerModel = GameObject.Find("PlayerModel");
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
                CraneC.GetComponent<CraneCheck3>().IsCrane3 = false;
                CantJump = true;
                Destroy(CraneA);
                Destroy(CraneB);
                Destroy(CraneC);
                PlayerModel.GetComponent<CharacterAnim>().CurrentFoot = PlayerModel.GetComponent<CharacterAnim>().FootStepW;

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
