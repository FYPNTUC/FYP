﻿using UnityEngine;
using System.Collections;

public class CheckTiltL : MonoBehaviour 
{

    public float SpeedOfTurning;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<Lift>().IsTurnBack == true &&GameObject.Find("Lift").GetComponent<Transform>().eulerAngles.x > 0 )
        {
            GameObject.Find("Lift").gameObject.transform.Rotate(Vector3.right * Time.deltaTime * SpeedOfTurning);           
        }

        if (GameObject.Find("Lift").GetComponent<Transform>().eulerAngles.x > 0 && GameObject.Find("Lift").GetComponent<Transform>().eulerAngles.x < 5)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Lift>().LimitReachedL = true;
            GameObject.FindGameObjectWithTag("Player").GetComponent<Lift>().IsTurnBack = false;
            Debug.Log("hit");
        }
    }
}
