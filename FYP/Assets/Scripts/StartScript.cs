using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour
{
    GameObject GangsterLook;
    public Animator animator;
    GameObject Gangster1;
    GameObject Gangster2;
    GameObject Worker1;
    GameObject Worker2;
    GameObject Door;
    GameObject Player;
    GameObject CSP1;
    GameObject CSP2;
    GameObject CSG2;
    GameObject Player2M;
    GameObject CSW1A;
    GameObject CSG1;
    GameObject Part1;
    GameObject Part2;
    GameObject Part3;
    GameObject WPart1;
    GameObject WPart2;
    GameObject W2Part1;
    GameObject W2Part2;

    public bool IsDown;
    public bool Part1Done;
    public bool Part2Done;
    public bool Part3Done;
    bool WK1T;
    bool WK1P;
    bool WK2T;
    bool WK2P;
    public float MovementSpeed;
    Vector3 Temp;
    float Timer;
    float Timer2;
    bool DoOnce;
    bool DoOnce2;
    bool DoOnce4;
    bool DoOnce5;
    float FTimer;
    bool DoOnce3;

    // Use this for initialization
    void Start()
    {
        GangsterLook = GameObject.Find("GangsterLook");
        IsDown = false;
        DoOnce5 = false;
        DoOnce3 = false;
        DoOnce4 = false;
        WK1T = false;
        WK1P = false;
        Timer2 = 1.5f;
        WK1T = false;
        WK1P = false;
        Part1 = GameObject.Find("Part1");
        Part2 = GameObject.Find("Part2");
        Part3 = GameObject.Find("Part3");
        WPart1 = GameObject.Find("WPart1");
        WPart2 = GameObject.Find("WPart2");
        W2Part1 = GameObject.Find("W2Part1");
        W2Part2 = GameObject.Find("W2Part2");
        CSW1A = GameObject.FindGameObjectWithTag("CSW1A");
        CSG2 = GameObject.FindGameObjectWithTag("CSG2");
        CSG1 = GameObject.FindGameObjectWithTag("CSG1");
        Player2M = GameObject.Find("Worker 2m");
        CSP1 = GameObject.Find("CSP1");
        CSP2 = GameObject.Find("CSP2");
        Player = GameObject.FindGameObjectWithTag("Player");
        Door = GameObject.Find("Building1_KeyOfficeDoor");
        DoOnce = false;
        Temp = gameObject.transform.position;
        animator = GetComponent<Animator>();
        Gangster1 = GameObject.FindGameObjectWithTag("CSW1");
        Gangster2 = GameObject.FindGameObjectWithTag("CSW2");
        Worker1 = GameObject.FindGameObjectWithTag("CSG1");
        Worker2 = GameObject.FindGameObjectWithTag("CSG2");
        Part1Done = false;
        Part2Done = false;
        Part3Done = false;
        MovementSpeed = 1;
        Timer = 8;
        FTimer = 7;
        DoOnce2 = false;



    }

    // Update is called once per frame
    void Update()
    {
      
        if (Door.GetComponent<StartDoorScript>().start == true)
        {
            if (WK1T == true && WK1P == false)
            {
                if (WPart1.GetComponent<AudioSource>().isPlaying == false)
                {
                    WPart1.GetComponent<AudioSource>().Play();
                    WK1P = true;
                }
            }

            if (WK2T == true && WK2P == false)
            {
                if (W2Part1.GetComponent<AudioSource>().isPlaying == false)
                {
                    W2Part1.GetComponent<AudioSource>().Play();
                    WK2P = true;
                }
            }

            //if (DoOnce == false)
            //{
            //    //tio whack

            //    //GameObject.FindGameObjectWithTag("CSW1").transform.position = 
            //    // new Vector3(GameObject.FindGameObjectWithTag("CSW1").transform.position.x, -0.12f, GameObject.FindGameObjectWithTag("CSW1").transform.position.z);                     //(0, -0.877f, 0);
            //    DoOnce = true;
            //}
            //gangster1
            if (gameObject.tag == "CSG1")
            {
                if (Part1Done == false)
                {
                    Player.GetComponent<OVRPlayerController>().enabled = false;
                    // transform.LookAt(GameObject.FindGameObjectWithTag("Player").transform);
                    transform.LookAt(CSP2.transform);
                    gameObject.transform.localEulerAngles = new Vector3(0, gameObject.transform.localEulerAngles.y, gameObject.transform.localEulerAngles.z);
                    animator.SetBool("IsWalking", true);
                    transform.Translate(Vector3.forward * Time.deltaTime * MovementSpeed);
                    Part1.GetComponent<AudioSource>().Play();
                    //transform.position = new Vector3(transform.posit+ion.x, Temp.y, transform.position.z);
                }

                else if (Part1Done == true && Part2Done == false)
                {
                    animator.SetBool("IsWalking", false);
                    transform.LookAt(Player.transform);
                    gameObject.transform.localEulerAngles = new Vector3(0, gameObject.transform.localEulerAngles.y, gameObject.transform.localEulerAngles.z);
                    animator.SetBool("IsTalking", true);
                    Timer -= Time.deltaTime;


                    if (Timer <= 0)
                    {
                        if (Part1.GetComponent<AudioSource>().isPlaying == false)
                        {
                            WK2T = true;
                        }
                        //WK1T = true;
                        animator.SetBool("IsTalking", false);
                        Player.GetComponent<OVRPlayerController>().enabled = true;

                        Part2Done = true;
                    }
                    //Part3.GetComponent<AudioSource>().Play();
                }
                if (Timer <= 0)
                {
                    Timer2 -= Time.deltaTime;
                    //print(Timer2);
                    if (Timer2 <= 0)
                    {
                        if (W2Part1.GetComponent<AudioSource>().isPlaying == false)
                        {
                            if (DoOnce2 == false)
                            {
                                Part2.GetComponent<AudioSource>().Play();
                                DoOnce2 = true;
                            }
                        }
                        if (DoOnce2 == true && Part2.GetComponent<AudioSource>().isPlaying == false)
                        {
                            if (DoOnce3 == false)
                            {
                                Part3.GetComponent<AudioSource>().Play();
                                DoOnce3 = true;
                            }
                        }
                    }
                }
                else if (Part2Done == true && Part3Done == false)
                {
                    //transform.LookAt(GameObject.FindGameObjectWithTag("CSW2").transform);

                    transform.LookAt(Player2M.transform);
                    gameObject.transform.localEulerAngles = new Vector3(0, gameObject.transform.localEulerAngles.y, gameObject.transform.localEulerAngles.z);
                }
            }
            //gangster2
            if (gameObject.tag == "CSG2")
            {
                if (Part1Done == false)
                {
                    transform.LookAt(CSP1.transform);
                    gameObject.transform.localEulerAngles = new Vector3(0, gameObject.transform.localEulerAngles.y, gameObject.transform.localEulerAngles.z);
                    animator.SetBool("IsWalking", true);
                    transform.Translate(Vector3.forward * Time.deltaTime * MovementSpeed);
                    //transform.position = new Vector3(transform.position.x, Temp.y, transform.position.z);
                }
                else if (Part1Done == true && Part2Done == false)
                {
                    animator.SetBool("IsWalking", false);

                    gameObject.transform.localEulerAngles = new Vector3(0, gameObject.transform.localEulerAngles.y, gameObject.transform.localEulerAngles.z);
                    //animator.SetBool("IsTalking", true);
                    Timer -= Time.deltaTime;
                    if (Timer <= 0)
                    {
                        Part2Done = true;
                    }
                }

                else if (Part2Done = true && Part3Done == false)
                {


                    if (CSG1.GetComponent<StartScript>().DoOnce3 == true && Part3.GetComponent<AudioSource>().isPlaying == false)
                    {
                        if (DoOnce4 == false)
                        {
                            WPart1.GetComponent<AudioSource>().Play();
                            DoOnce4 = true;
                        }
                        if (DoOnce4 == true && WPart1.GetComponent<AudioSource>().isPlaying == false)
                        {
                            if (DoOnce5 == false)
                            {
                                WPart2.GetComponent<AudioSource>().Play();
                                DoOnce5 = true;
                            }
                        }
                        FTimer -= Time.deltaTime;
                        transform.LookAt(CSW1A.transform);
                        gameObject.transform.localEulerAngles = new Vector3(0, gameObject.transform.localEulerAngles.y, gameObject.transform.localEulerAngles.z);
                        animator.SetBool("IsGuarding", true);
                        animator.SetBool("IsFight", true);
                        //  x   print(FTimer);

                        if (FTimer <= 0)
                        {
                            animator.SetBool("IsFight", false);
                            Part3Done = true;
                            gameObject.GetComponent<AIScript>().enabled = true;
                            gameObject.GetComponent<AIScript>().IsFollowing = true;
                            gameObject.GetComponent<StartScript>().enabled = false;

                        }
                    }
                }
            }
            //Worker1
            if (gameObject.tag == "CSW1")
            {

                transform.LookAt(CSG2.transform);
                gameObject.transform.localEulerAngles = new Vector3(0, gameObject.transform.localEulerAngles.y, gameObject.transform.localEulerAngles.z);
                if (CSG2.GetComponent<StartScript>().Part2Done == true && CSG1.GetComponent<StartScript>().DoOnce3 == true)
                {

                    animator.SetBool("GettingHit", true);
                }
                if (CSG2.GetComponent<StartScript>().Part3Done == true)
                {
                    animator.SetBool("GetRekt", true);
                    if (DoOnce == false)
                    {
                        gameObject.transform.Translate(0, 0.1056147f, 0);
                        DoOnce = true;
                    }
                }
            }
            //Worker2
            if (gameObject.tag == "CSW2")
            {
                if (CSG2.GetComponent<StartScript>().Part2Done == true)
                {

                    transform.LookAt(CSG1.transform);
                    gameObject.transform.localEulerAngles = new Vector3(0, gameObject.transform.localEulerAngles.y, gameObject.transform.localEulerAngles.z);
                    if (Part1Done == false)
                    {
                        animator.SetBool("IsWalking", true);
                        transform.Translate(Vector3.forward * Time.deltaTime * MovementSpeed);
                    }
                    else if (Part1Done == true)
                    {
                        animator.SetBool("IsWalking", false);
                    }
                }

                if (IsDown == true)
                {

                    if (DoOnce == false)
                    {
                        animator.SetBool("GetRekt", true);
                        gameObject.transform.Translate(0, 0.1056147f, 0);
                        DoOnce = true;
                    }
                    CSG1.GetComponent<Animator>().SetBool("IsRun", true);
                    CSG2.GetComponent<Animator>().SetBool("IsRun", true);
                    CSG1.transform.LookAt(GangsterLook.transform);
                    CSG1.transform.Translate(Vector3.forward * Time.deltaTime * 2);
                    CSG1.transform.localEulerAngles = new Vector3(0, CSG1.transform.localEulerAngles.y, CSG1.transform.localEulerAngles.z);

                    CSG2.transform.LookAt(GangsterLook.transform);
                    CSG2.transform.Translate(Vector3.forward * Time.deltaTime * 2);
                    CSG2.transform.localEulerAngles = new Vector3(0, CSG2.transform.localEulerAngles.y, CSG2.transform.localEulerAngles.z);

                }
            }
        }
    }

}
