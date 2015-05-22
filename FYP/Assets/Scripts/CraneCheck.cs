﻿using UnityEngine;
using System.Collections;

public class CraneCheck : MonoBehaviour
{
    GameObject Player;
    public bool IsCrane1;
    public bool HoldIt;
    bool DoOnce;
    //GameObject CController;
    // Use this for initialization
    void Start()
    {
        //CController = GameObject.Find("");
        DoOnce = false;
        Player = GameObject.FindGameObjectWithTag("Player");
        IsCrane1 = false; ;
        HoldIt = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.GetComponent<CraneController>().CurrentCrane == Player.GetComponent<CraneController>().Crane3)
        {
            if (HoldIt == true)
            {
                if (Input.GetKeyDown("g") || Input.GetButtonDown("cButtonA"))
                {
                    Player.GetComponent<CraneController>().CanBeMoved = true;
                    HoldIt = false;
                    IsCrane1 = true;
                }
            }
            else if (IsCrane1 == true)
            {
                Vector3 temp;
                temp = gameObject.transform.position;
                temp.y += 0.6f;
                Player.transform.position = temp;
                if (Input.GetKeyDown("g") || Input.GetButtonDown("cButtonA"))
                {
                    Player.GetComponent<CraneController>().CanBeMoved = false;
                    HoldIt = true;
                    IsCrane1 = false;
                }
            }
        }



    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (HoldIt == false)
            {
                //Debug.Log("pls");
                IsCrane1 = true;
            }
            if (DoOnce == false)
            {
                Player.GetComponent<CraneController>().CanBeMoved = true;
                DoOnce = true;
            }
            Player.GetComponent<CraneController>().CurrentCrane = Player.GetComponent<CraneController>().Crane3;
            Player.GetComponent<CraneController>().CurrentTrolley = Player.GetComponent<CraneController>().Trolley3;
            Player.GetComponent<CraneController>().CurrentRope = Player.GetComponent<CraneController>().Rope3;
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {

            if (HoldIt == false)
            {
                //Debug.Log("pls");
                IsCrane1 = true;
            }
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            IsCrane1 = false;
            //Debug.Log("i stay");
            //Player.transform.parent = gameObject.transform;
        }
    }

    //void OnTriggerExit(Collider col)
    //{
    //    if (col.gameObject.tag == "Player")
    //    {
    //        Player.transform.parent = null;
    //    }
    //}
}
