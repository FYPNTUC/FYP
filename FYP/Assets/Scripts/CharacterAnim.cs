using UnityEngine;
using System.Collections;

public class CharacterAnim : MonoBehaviour
{
    public bool IsCarrying;
    public bool IsBalancing;
    public bool IsTopBalancing;
    public bool IsFlyingFox;

    GameObject PlayerModel;
    // Use this for initialization
    float timer;

    void Start()
    {
        PlayerModel = GameObject.Find("PlayerModel");     
        IsBalancing = false;
        IsCarrying = false;
        IsTopBalancing = false;
        IsFlyingFox = false;
        timer = 0.5f;

    }

    // Update is called once per frame
    void Update()
    {
        //PlayerModel.GetComponent<Animation>().GetComponent<Animation>()["Walk"].speed = -1;
        //horizontal controls incase
        //if (Input.GetAxis("cLeftJoystickHori") > 0.19)
        //{
        //    
        //}

        //if (Input.GetAxis("cLeftJoystickHori") < 0)
        //{
        //    Debug.Log(Input.GetAxis("cLeftJoystickHori"));
        //}

        //if (Input.GetAxis("cLeftJoystickVerti") > 0.19)
        //{
        //    
        //}

        if (IsFlyingFox == true)
        {
            //speed up the animation 
            PlayerModel.GetComponent<Animation>().GetComponent<Animation>()["PreparingFlyingFox"].speed = 4;
            PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("PreparingFlyingFox");
        }

        if (IsCarrying == true)
        {
            if (Input.GetAxis("cVerticalDPad") > 0.001)
            {

                PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("WalkWithBox");
            }

            if (Input.GetKey("w"))
            {
                PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("WalkWithBox");
            }

            if (Input.GetAxis("cLeftJoystickVerti") < 0)
            {

                PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("WalkWithBox");
            }
        }
        if (IsTopBalancing == true)
        {
            PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("Balancing");
            PlayerModel.GetComponent<Animation>().GetComponent<Animation>()["Balancing"].speed = 1;
        }

        else if (IsBalancing == true)
        {
            //if the player is not on ground start a timer , if the timer reach 0 reset the player
            if (GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController>().isGrounded == false)
            {

                timer -= Time.deltaTime;
                //Debug.Log(timer);
                if (timer <= 0)
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<FadeInOut>().ChangeLevelFade = true;
                    timer = 0.5f;
                }
            }
            //reset the timer if the player made it to ground in time
            else if (GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController>().isGrounded == true)
            {
                timer = 0.5f;
            }

            // if the player moves forward play the walking animation
            if (Input.GetAxis("cVerticalDPad") > 0.001)
            {
                PlayerModel.GetComponent<Animation>().GetComponent<Animation>()["Balancing"].speed = 1;
                PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("Balancing");
            }

            if (Input.GetKey("w"))
            {
                PlayerModel.GetComponent<Animation>().GetComponent<Animation>()["Balancing"].speed = 1;
                PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("Balancing");
            }

            if (Input.GetAxis("cLeftJoystickVerti") < 0)
            {
                PlayerModel.GetComponent<Animation>().GetComponent<Animation>()["Balancing"].speed = 1;
                PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("Balancing");
            }

        }

        else if (IsBalancing == false && IsFlyingFox == false && IsCarrying == false)//placed so that the flying fox and balancing animation will not be interupted
        {
            if (Input.GetAxis("cVerticalDPad") > 0.001)
            {
                //PlayerModel.GetComponent<Animation>().animation["Walk"].speed = 1;
                PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("Walk");
            }

            if (Input.GetKey("w"))
            {
                // PlayerModel.GetComponent<Animation>().animation["Walk"].speed = 1;
                PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("Walk");
            }

            if (Input.GetAxis("cLeftJoystickVerti") < 0)
            {
                // PlayerModel.GetComponent<Animation>().animation["Walk"].speed = 1;
                PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("Walk");
            }
        }



        if (Input.anyKey == false && Input.GetAxis("cLeftJoystickVerti") == 0 && Input.GetAxis("cVerticalDPad") == 0)
        {
            PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Stop("Walk");
            if (IsTopBalancing == false)
            {
                PlayerModel.GetComponent<Animation>().GetComponent<Animation>()["Balancing"].speed = 0;
            }
        }
        //jumping animation
        if (Input.GetKeyDown("space") || Input.GetButtonDown("cButtonB"))
        {
            if (IsTopBalancing == false)
            {
                PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Stop("Walk");
                PlayerModel.GetComponent<Animation>().GetComponent<Animation>()["Jump"].speed = 2.5f;
                PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("Jump");
            }
        }
        //set the animation to idle if no key is pressed
        else if (PlayerModel.GetComponent<Animation>().GetComponent<Animation>().isPlaying == false && IsBalancing == false && IsCarrying == false)
        {
            PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("Idle");
        }
    }

    //cVerticalDPad cHorizontalDPad
}