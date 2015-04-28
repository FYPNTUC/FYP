using UnityEngine;
using System.Collections;

public class CharacterAnim : MonoBehaviour
{
    public bool IsCarrying;
    public bool IsBalancing;
    public bool IsTopBalancing;

    GameObject PlayerModel;
    GameObject PlayerModel2;
    // Use this for initialization
     float timer;
           
    void Start()
    {
        PlayerModel = GameObject.Find("PlayerModel");
        PlayerModel2 = GameObject.Find("PlayerModel2");
        IsBalancing = false;
        IsCarrying = false;
        IsTopBalancing = false;
        timer = 0.5f;

    }

    // Update is called once per frame
    void Update()
    {

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

        if (Input.GetAxis("cLeftJoystickVerti") < 0)
        {

        }

        if (IsCarrying == true)
        {
            if (Input.GetAxis("cVerticalDPad") > 0.001)
            {
                //PlayerModel.GetComponent<Animation>().animation["Walk"].speed = 1;
                PlayerModel2.GetComponent<Animation>().GetComponent<Animation>().Play("MoveTheBox");
            }

            if (Input.GetKey("w"))
            {
                // PlayerModel.GetComponent<Animation>().animation["Walk"].speed = 1;
                PlayerModel2.GetComponent<Animation>().GetComponent<Animation>().Play("MoveTheBox");
            }

            if (Input.GetAxis("cLeftJoystickVerti") < 0)
            {
                // PlayerModel.GetComponent<Animation>().animation["Walk"].speed = 1;
                PlayerModel2.GetComponent<Animation>().GetComponent<Animation>().Play("MoveTheBox");
            }
        }
        if (IsTopBalancing == true)
        {
            PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("Balancing");
            PlayerModel.GetComponent<Animation>().GetComponent<Animation>()["Balancing"].speed = 1;
        }

        else if (IsBalancing == true)
        {
           
            if (GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController>().isGrounded == false)
            {
               
                timer -= Time.deltaTime;
                Debug.Log(timer);
                if (timer <=0)
                {             
                    GameObject.FindGameObjectWithTag("Player").GetComponent<FadeInOut>().ChangeLevelFade = true;
                    timer = 0.5f;
                }
            }

            else if (GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController>().isGrounded == true)
            {
                timer = 0.5f;
            }
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

        else if (IsBalancing == false)
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
            PlayerModel2.GetComponent<Animation>().GetComponent<Animation>().Stop("MoveTheBox");
            if (IsTopBalancing == false)
            {
                //Debug.Log("wot");
                PlayerModel.GetComponent<Animation>().GetComponent<Animation>()["Balancing"].speed = 0;
            }
            //PlayerModel.GetComponent<Animation>().animation["Walk"].speed = 0;
        }

        if (Input.GetKeyDown("space") || Input.GetButtonDown("cButtonB"))
        {
            PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Stop("Walk");
            PlayerModel.GetComponent<Animation>().GetComponent<Animation>()["Jump"].speed = 2.5f;
            PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("Jump");
        }
        else if (PlayerModel.GetComponent<Animation>().GetComponent<Animation>().isPlaying == false && IsBalancing == false)
        {
            PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("Idle");
        }

        else if (PlayerModel2.GetComponent<Animation>().GetComponent<Animation>().isPlaying == false)
        {
            PlayerModel2.GetComponent<Animation>().GetComponent<Animation>().Stop("MoveTheBox");
        }
    }

    //cVerticalDPad cHorizontalDPad
}
