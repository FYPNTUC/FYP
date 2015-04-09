﻿using UnityEngine;
using System.Collections;

public class FlyingFox : MonoBehaviour 
{
    public bool NearZip;
    GameObject Player;
    GameObject Checker;
    bool ZipIsMoving;
	// Use this for initialization
	void Start ()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Checker = GameObject.Find("FlyingFoxChecker");
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (NearZip == true)
        {
            if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
            {
                Player.transform.parent = gameObject.transform;
                Player.GetComponent<OVRPlayerController>().enabled = false;
                GameObject.Find("GUI").GetComponent<Renderer>().enabled = false;
                Destroy(Checker);
                NearZip = true;
                ZipIsMoving = true;                            
                NearZip = false;
                //Debug.Log("flyingfox has problem");
            }
        }
        if (ZipIsMoving == true)
        {
            MoveTheZip();      
        }

        if (gameObject.transform.position.z < -24)
        {
            ZipIsMoving = false;
            Player.transform.parent = null;
            Player.GetComponent<OVRPlayerController>().enabled = true;
        }
    }

    void MoveTheZip()
    {
        gameObject.transform.Translate(Vector3.forward * Time.deltaTime * 50);
    }
}
