using UnityEngine;
using System.Collections;

public class CharacterAnim : MonoBehaviour 
{

    public bool IsBalancing;
    GameObject PlayerModel;
	// Use this for initialization
	void Start () 
    {
        PlayerModel = GameObject.Find("PlayerModel");
        IsBalancing = false;
   
	}
	
	// Update is called once per frame
	void Update () 
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
        if (IsBalancing == true)
        {
            if (Input.GetAxis("cVerticalDPad") > 0.001)
            {
                PlayerModel.GetComponent<Animation>().animation["Balancing"].speed = 1;
                PlayerModel.GetComponent<Animation>().animation.Play("Balancing");
            }

            if (Input.GetKey("w"))
            {
                PlayerModel.GetComponent<Animation>().animation["Balancing"].speed = 1;
                PlayerModel.GetComponent<Animation>().animation.Play("Balancing");
            }

            if (Input.GetAxis("cLeftJoystickVerti") < 0)
            {
                PlayerModel.GetComponent<Animation>().animation["Balancing"].speed = 1;
                PlayerModel.GetComponent<Animation>().animation.Play("Balancing");
            }
        }

        else if (IsBalancing == false)
        {
            if (Input.GetAxis("cVerticalDPad") > 0.001)
            {
                //PlayerModel.GetComponent<Animation>().animation["Walk"].speed = 1;
                PlayerModel.GetComponent<Animation>().animation.Play("Walk");
            }

            if (Input.GetKey("w"))
            {
               // PlayerModel.GetComponent<Animation>().animation["Walk"].speed = 1;
                PlayerModel.GetComponent<Animation>().animation.Play("Walk");
            }

            if (Input.GetAxis("cLeftJoystickVerti") < 0)
            {
               // PlayerModel.GetComponent<Animation>().animation["Walk"].speed = 1;
                PlayerModel.GetComponent<Animation>().animation.Play("Walk");
            }
        }

        if (Input.anyKey == false && Input.GetAxis("cLeftJoystickVerti") == 0 && Input.GetAxis("cVerticalDPad") == 0) 
        {
            PlayerModel.GetComponent<Animation>().animation.Stop("Walk");
            PlayerModel.GetComponent<Animation>().animation["Balancing"].speed = 0;
            //PlayerModel.GetComponent<Animation>().animation["Walk"].speed = 0;
        }

        if (Input.GetKey("f") || Input.GetButtonDown("cButtonB"))
        {
            PlayerModel.GetComponent<Animation>().animation["Jump"].speed = 2.5f;
            PlayerModel.GetComponent<Animation>().animation.Play("Jump");
        }
        else if (PlayerModel.GetComponent<Animation>().animation.isPlaying == false) 
       
        {
            PlayerModel.GetComponent<Animation>().animation.Play("Idle");
        }

       
	}

    //cVerticalDPad cHorizontalDPad
}
