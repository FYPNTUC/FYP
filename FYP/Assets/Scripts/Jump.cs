﻿using UnityEngine;
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

    float Timer;
    int Selection;
    GameObject Display;
    GameObject Player;
    public bool DoOnce;


    // Use this for initialization
    void Start()
    {
        CanJump = false;
        DoOnce = false;
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
        if (CanJump == true)
        {
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
                    Display.GetComponent<Renderer>().material = Pic1;
                    if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
                    {
                        Jump1 = true;
                    }
                }

                else if (Selection == 1)
                {
                    Display.GetComponent<Renderer>().material = Pic2;
                    if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
                    {
                        Jump2 = true;
                    }
                }

                else if (Selection == 2)
                {
                    Display.GetComponent<Renderer>().material = Pic3;

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
                    Player.transform.Translate(Vector3.up * 1);
                    DoOnce = true;
                }
            }
            else if (Jump2 == true)
            {

                if (DoOnce == false)
                {
                    Player.transform.Translate(Vector3.forward * 1.5f);
                    DoOnce = true;
                }
            }
            else if (Jump3 == true)
            {
                if (DoOnce == false)
                {
                    Player.transform.Translate(Vector3.forward * 6);
                    DoOnce = true;
                }
            }
        }
    }
}
