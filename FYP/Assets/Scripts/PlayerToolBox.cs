using UnityEngine;
using System.Collections;

public class PlayerToolBox : MonoBehaviour
{
    GameObject Box1;
    GameObject Box2;
    Animator animator;
    GameObject PlankCheckS;
    GameObject Screw1;
    GameObject Screw2;
    GameObject HammerTb;
    GameObject Player;
    GameObject BoxLoc;
    GameObject HammerP;
    Vector3 StartingLoc;
    GameObject PlayerModel;
    public bool IsOut;
    bool IsCounting;

    float Timer;
    // Use this for initialization
    void Start()
    {
        Box1 = GameObject.Find("MoveAbleBox");
        Box2 = GameObject.Find("MoveAbleBox1");
        PlayerModel = GameObject.Find("PlayerModel");
        animator = GetComponent<Animator>();
        PlankCheckS = GameObject.Find("PlankCheckS");
        HammerP = GameObject.Find("HammerP");
        Screw1 = GameObject.Find("ScrewTB1");
        Screw2 = GameObject.Find("ScrewTB2");
        HammerTb = GameObject.Find("HammerTB");
        BoxLoc = GameObject.Find("BoxLoc2");
        StartingLoc = gameObject.transform.position;
        Player = GameObject.FindGameObjectWithTag("Player");
        IsOut = false;
        Timer = 1.5f;
        IsCounting = false;
    }

    // Update is called once per frames
    void Update()
    {
        if (PlayerModel.GetComponent<CharacterAnim>().IsTopBalancing == false && Box1.GetComponent<MoveUpBox>().HasBox == false && Box2.GetComponent<MoveUpBox>().HasBox2 == false)
        {
            if (IsOut == false)
            {
                if (Input.GetKeyDown("u") || Input.GetButtonDown("cButtonX"))
                {
                    PlayerModel.GetComponent<Animation>().Play("TakeOutToolBox");
                    PlayerModel.GetComponent<Animation>().PlayQueued("HoldingToolBoxIdle");
                    animator.SetBool("IsOpening", true);
                    animator.SetBool("IsClosing", false);
                    gameObject.transform.position = BoxLoc.transform.position;
                    gameObject.transform.rotation = BoxLoc.transform.rotation;
                    Player.GetComponent<OVRPlayerController>().enabled = false;
                    IsOut = true;
                }
            }
            else if (IsOut == true)
            {
                if (Input.GetKeyDown("u") || Input.GetButtonDown("cButtonX"))
                {
                    PlayerModel.GetComponent<Animation>().Play("PutBackToolBox");
                    //PlayerModel.GetComponent<Animation>().PlayQueued
                    animator.SetBool("IsOpening", false);
                    animator.SetBool("IsClosing", true);
                    IsCounting = true;

                }
            }
        }
        if (IsCounting == true)
        {
            Timer -= Time.deltaTime;
        }
        if (Timer <= 0)
        {
            gameObject.transform.position = StartingLoc;
            Player.GetComponent<OVRPlayerController>().enabled = true;
            IsOut = false;
            Timer = 1.5f;
            IsCounting = false;
        }
        if (HammerP.GetComponent<GotItem>().ObtainedH == true)
        {
            HammerTb.GetComponent<Renderer>().enabled = true;
        }
        if (PlankCheckS.GetComponent<ShakePlank>().Screw == 1)
        {
            Screw1.GetComponent<Renderer>().enabled = true;
        }

        else if (PlankCheckS.GetComponent<ShakePlank>().Screw == 2)
        {
            Screw2.GetComponent<Renderer>().enabled = true;
        }
    }
}
