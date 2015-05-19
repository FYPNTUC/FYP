using UnityEngine;
using System.Collections;

public class CharacterAnim : MonoBehaviour
{
    public bool IsCarrying;
    public bool IsBalancing;
    public bool IsTopBalancing;
    public bool IsFlyingFox;
    public bool IsLongJump;
    public bool IsOnCrane;

    GameObject BoxLoc;
    double Checker;
    double Checker2;
    public bool RaisingBox;
    public bool IsUp;
    public bool DownBox;

    public bool IsBox1;
    public bool IsBox2;
    GameObject PlayerModel;
    GameObject ToolBox;
    bool OAnim;
    // Use this for initialization
    float timer;

    void Start()
    {
        IsOnCrane = false;
        ToolBox = GameObject.Find("PlayerToolBox");
        BoxLoc = GameObject.Find("BoxLoc");
        PlayerModel = GameObject.Find("PlayerModel");
        IsBalancing = false;
        IsCarrying = false;
        IsTopBalancing = false;
        IsFlyingFox = false;
        timer = 0.5f;
        RaisingBox = false;
        IsUp = false;
        DownBox = false;
        IsBox1 = false;
        IsBox2 = false;
        OAnim = false;
        IsLongJump = false;

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
        Checker = BoxLoc.transform.position.y + 0.65222;
        Checker2 = BoxLoc.transform.position.y;
        if (IsLongJump == true)
        {
            //PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("IdleToJump");
        }
        if (IsFlyingFox == true)
        {
            //speed up the animation 
            PlayerModel.GetComponent<Animation>().GetComponent<Animation>()["PreparingFlyingFox"].speed = 4;
            PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("PreparingFlyingFox");
        }

        if (IsCarrying == true)
        {
            if (OAnim == false && GameObject.FindGameObjectWithTag("Player").GetComponent<OVRPlayerController>().enabled != false)
            {
                if (Input.GetAxis("cVerticalDPad") > 0.001)
                {
                    PlayerModel.GetComponent<Animation>().GetComponent<Animation>()["WalkWithBox"].speed = 1;
                    PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("WalkWithBox");
                }

                if (Input.GetKey("w"))
                {
                    PlayerModel.GetComponent<Animation>().GetComponent<Animation>()["WalkWithBox"].speed = 1;
                    PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("WalkWithBox");
                }

                if (Input.GetAxis("cLeftJoystickVerti") < 0)
                {

                    PlayerModel.GetComponent<Animation>().GetComponent<Animation>()["WalkWithBox"].speed = 1;
                    PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("WalkWithBox");
                }
            }

            if (Input.GetKeyDown("t") || Input.GetButtonDown("cButtonY"))
            {
                if (RaisingBox == false && IsUp == false)
                {

                    if (GameObject.Find("MoveAbleBox").GetComponent<MoveUpBox>().HasBox == true)
                    {
                        PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("RaiseUpBox");
                        RaisingBox = true;
                        IsBox1 = true;
                        OAnim = true;
                        GameObject.FindGameObjectWithTag("Player").GetComponent<OVRPlayerController>().enabled = false;
                    }

                    if (GameObject.Find("MoveAbleBox1").GetComponent<MoveUpBox>().HasBox2 == true)
                    {
                        //print("BOX2");
                        PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("RaiseUpBox");
                        RaisingBox = true;
                        IsBox2 = true;
                        OAnim = true;
                        GameObject.FindGameObjectWithTag("Player").GetComponent<OVRPlayerController>().enabled = false;
                    }

                }

                else if (RaisingBox == false && IsUp == true)
                {

                    if (GameObject.Find("MoveAbleBox").GetComponent<MoveUpBox>().HasBox == true)
                    {
                        PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("LowerBox");
                        DownBox = true;
                    }


                    if (GameObject.Find("MoveAbleBox1").GetComponent<MoveUpBox>().HasBox2 == true)
                    {
                        PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("LowerBox");
                        DownBox = true;
                    }
                }
            }
            if (RaisingBox == true)
            {
                MoveTheBox();
            }
            if (DownBox == true)
            {
                MoveTheBoxDown();
            }
            if (IsBox1 == true)
            {
                if (GameObject.Find("MoveAbleBox").transform.position.y >= Checker)
                {
                    RaisingBox = false;
                    IsUp = true;
                    OAnim = false;
                }

                if (GameObject.Find("MoveAbleBox").transform.position.y <= Checker2)
                {
                    DownBox = false;
                    IsUp = false;
                    OAnim = false;
                    GameObject.FindGameObjectWithTag("Player").GetComponent<OVRPlayerController>().enabled = true;
                }
            }

            if (IsBox2 == true)
            {
                if (GameObject.Find("MoveAbleBox1").transform.position.y >= Checker)
                {
                    RaisingBox = false;
                    IsUp = true;
                    OAnim = false;
                }

                if (GameObject.Find("MoveAbleBox1").transform.position.y <= Checker2)
                {
                    DownBox = false;
                    IsUp = false;
                    OAnim = false;
                    GameObject.FindGameObjectWithTag("Player").GetComponent<OVRPlayerController>().enabled = true;
                }
            }
        }
        if (IsTopBalancing == true)
        {
            PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("2nBal");
            PlayerModel.GetComponent<Animation>().GetComponent<Animation>()["2nBal"].speed = 1;
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
                PlayerModel.GetComponent<Animation>().GetComponent<Animation>()["2nBal"].speed = 1;
                PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("2nBal");
            }

            if (Input.GetKey("w"))
            {
                PlayerModel.GetComponent<Animation>().GetComponent<Animation>()["2nBal"].speed = 1;
                PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("2nBal");
            }

            if (Input.GetAxis("cLeftJoystickVerti") < 0)
            {
                PlayerModel.GetComponent<Animation>().GetComponent<Animation>()["2nBal"].speed = 1;
                PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("2nBal");
            }

        }
        //placed so that the flying fox and balancing animation will not be interupted
        else if (IsBalancing == false && IsFlyingFox == false && IsCarrying == false && ToolBox.GetComponent<PlayerToolBox>().IsOut == false && IsOnCrane == false)
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
            PlayerModel.GetComponent<Animation>().GetComponent<Animation>()["WalkWithBox"].speed = 0;

            if (IsTopBalancing == false)
            {
                PlayerModel.GetComponent<Animation>().GetComponent<Animation>()["2nBal"].speed = 0;
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
        else if (PlayerModel.GetComponent<Animation>().GetComponent<Animation>().isPlaying == false && IsBalancing == false && IsCarrying == false && ToolBox.GetComponent<PlayerToolBox>().IsOut == false && IsOnCrane == false)
        {
            PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("Idle");
        }
    }

    void MoveTheBox()
    {
        if (GameObject.Find("MoveAbleBox").GetComponent<MoveUpBox>().HasBox == true)
        {
            GameObject.Find("MoveAbleBox").transform.Translate(Vector3.up * Time.deltaTime * 0.6f);
        }
        if (GameObject.Find("MoveAbleBox1").GetComponent<MoveUpBox>().HasBox2 == true)
        {
            GameObject.Find("MoveAbleBox1").transform.Translate(Vector3.up * Time.deltaTime * 0.6f);
        }
    }

    void MoveTheBoxDown()
    {
        if (GameObject.Find("MoveAbleBox").GetComponent<MoveUpBox>().HasBox == true)
        {
            GameObject.Find("MoveAbleBox").transform.Translate(Vector3.down * Time.deltaTime * 0.6f);
        }
        if (GameObject.Find("MoveAbleBox1").GetComponent<MoveUpBox>().HasBox2 == true)
        {
            GameObject.Find("MoveAbleBox1").transform.Translate(Vector3.down * Time.deltaTime * 0.6f);
        }
    }

    //cVerticalDPad cHorizontalDPad
}