﻿using UnityEngine;
using System.Collections;

public class ResetManager : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Player")
        {
            if (gameObject.name == "PlayerPass1")
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<FadeInOut>().ResetLocation = GameObject.Find("ResetLocation6");
            }

            else if (gameObject.name == "PlayerPass2")
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<FadeInOut>().ResetLocation = GameObject.Find("ResetLocation7");
            }
            else if (gameObject.name == "PlayerPass3")
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<FadeInOut>().ResetLocation = GameObject.Find("ResetLocation8");
            }
            else if (gameObject.name == "PlayerPass4")
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<FadeInOut>().ResetLocation = GameObject.Find("ResetLocation9");
            }
            else if (gameObject.name == "PlayerPass5")
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<FadeInOut>().ResetLocation = GameObject.Find("ResetLocation10");
            }
        }

    }
}
