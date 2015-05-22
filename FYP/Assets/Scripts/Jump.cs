using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour
{
    public bool Jump1;
    public bool Jump2;
    public bool Jump3;
    public bool CanJump;
    Material Pic1;
    public Material Pic2;
    public Material Pic3;
    public GameObject Arrow1;
    public GameObject Arrow2;
    public GameObject Arrow3;
    GameObject Marker;
    GameObject PlayerModel;

    GameObject JumpCheck;
    float Timer;
    int Selection;
    GameObject Display;
    GameObject Player;
    public bool DoOnce;
    bool DoOnce2;
    bool DoingJump1;
    bool DoingJump2;
    bool DoingJump3;
    // Use this for initialization
    void Start()
    {
        DoingJump1 = false;
        DoingJump2 = false;
        DoingJump3 = false;
        JumpCheck = GameObject.Find("JumpCheck");
        PlayerModel = GameObject.Find("PlayerModel");
        Marker = GameObject.Find("Marker");
        Arrow1 = GameObject.Find("Arrow1");
        Arrow2 = GameObject.Find("Arrow2");
        Arrow3 = GameObject.Find("Arrow3");
        CanJump = false;
        DoOnce = false;
        DoOnce2 = false;
        Jump1 = false;
        Jump2 = false;
        Jump3 = false;
        Timer = 0.5f;
        Selection = 0;
        Display = GameObject.Find("JumpDisplay");
        Pic1 = Display.GetComponent<Renderer>().material;
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (DoingJump1 == true)
        {
            Player.GetComponent<OVRPlayerController>().enabled = false;
            Player.transform.Translate(Vector3.up * Time.deltaTime * 5);
            PlayerModel.GetComponent<Animation>().Stop("JumpIdle");
            PlayerModel.GetComponent<Animation>().Play("FailJump");
            if (Player.transform.position.y >= 122.97f)
            {
                DoingJump1 = false;
                Player.GetComponent<OVRPlayerController>().enabled = true;
            }
        }

        if (DoingJump2 == true)
        {
            Player.transform.Translate(Vector3.forward * Time.deltaTime * 15f);
            PlayerModel.GetComponent<Animation>().Stop("JumpIdle");
            PlayerModel.GetComponent<Animation>().Play("LJump");
            Player.GetComponent<OVRPlayerController>().enabled = false;
            if (Player.transform.position.z <= -43.91f)
            {
                Player.GetComponent<OVRPlayerController>().enabled = true;
                DoingJump2 = false;
            }
        }
        if (DoingJump3 == true)
        {

            Player.transform.Translate(Vector3.forward * Time.deltaTime * 15f);
            PlayerModel.GetComponent<Animation>().Stop("JumpIdle");
            PlayerModel.GetComponent<Animation>().Play("LJump");
            Player.GetComponent<OVRPlayerController>().enabled = false;
            if (Player.transform.position.z <= -46.52f)
            {
                Player.GetComponent<OVRPlayerController>().enabled = true;
                DoingJump3 = false;
            }
        }
        if (CanJump == true)
        {
            //if (DoOnce2 == false)
            //{
            Player.transform.rotation = Marker.transform.rotation;
            PlayerModel.GetComponent<Animation>().GetComponent<Animation>()["JumpIdle"].speed = 0.5f;
            PlayerModel.GetComponent<Animation>().Play("JumpIdle");
            //  DoOnce2 = true;
            //}
      
            if (Jump1 == false && Jump2 == false && Jump3 == false)
            {
                if (Selection < 3)
                {
                    Timer -= Time.deltaTime;
                    if (Timer <= 0)
                    {
                        Selection++;
                        Timer = 0.5f;
                    }
                }
                else if (Selection >= 3)
                {
                    Selection = 0;
                }
                if (Selection == 0)
                {
                    Arrow1.GetComponent<Renderer>().enabled = true;
                    Arrow2.GetComponent<Renderer>().enabled = false;
                    Arrow3.GetComponent<Renderer>().enabled = false;
                    if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
                    {
                        Jump1 = true;
                    }
                }

                else if (Selection == 1)
                {
                    Arrow1.GetComponent<Renderer>().enabled = true;
                    Arrow2.GetComponent<Renderer>().enabled = true;
                    Arrow3.GetComponent<Renderer>().enabled = false;
                    if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
                    {
                        Jump2 = true;
                    }
                }

                else if (Selection == 2)
                {
                    Arrow1.GetComponent<Renderer>().enabled = true;
                    Arrow2.GetComponent<Renderer>().enabled = true;
                    Arrow3.GetComponent<Renderer>().enabled = true;

                    if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
                    {
                        Jump3 = true;
                    }
                }
            }

            if (Jump1 == true)
            {

                if (DoOnce == false)
                {
                   
                    DoOnce = true;
                    JumpCheck.GetComponent<JumpCheck>().ResetTime = 2;
                    Arrow1.GetComponent<Renderer>().enabled = false;
                    Arrow2.GetComponent<Renderer>().enabled = false;
                    Arrow3.GetComponent<Renderer>().enabled = false;
                    DoingJump1 = true;
                }
            }

          
            else if (Jump2 == true)
            {

                if (DoOnce == false)
                {
                    DoOnce = true;
                   
                    JumpCheck.GetComponent<JumpCheck>().ResetTime = 2;
                    Arrow1.GetComponent<Renderer>().enabled = false;
                    Arrow2.GetComponent<Renderer>().enabled = false;
                    Arrow3.GetComponent<Renderer>().enabled = false;
                    DoingJump2 = true;
                }
            }
            else if (Jump3 == true)
            {
                if (DoOnce == false)
                {
    
                    DoOnce = true;                
                    JumpCheck.GetComponent<JumpCheck>().ResetTime = 2;
                    Arrow1.GetComponent<Renderer>().enabled = false;
                    Arrow2.GetComponent<Renderer>().enabled = false;
                    Arrow3.GetComponent<Renderer>().enabled = false;
                    DoingJump3 = true;
                }
            }
        }
    }
}
