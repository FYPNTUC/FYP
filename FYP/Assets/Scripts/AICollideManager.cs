﻿using UnityEngine;
using System.Collections;

public class AICollideManager : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Player")
        {
            //GameObject.Find("Gangster1").GetComponent<AIScript>().Combat = true;
            GetComponentInParent<AIScript>().Combat = true;
        }

        if (col.gameObject.tag == "Worker")
        {
            GameObject.Find("Worker").GetComponent<WorkerScript>().IsCombat = true;
        }

    }

    void OnTriggerExit(Collider col)
    {

        if (col.gameObject.tag == "Player")
        {
            //GameObject.Find("Gangster1").GetComponent<AIScript>().Combat = true;
            GetComponentInParent<AIScript>().Combat = false;
            GetComponentInParent<AIScript>().IsFollowing = true;
            GetComponentInParent<AIScript>().MovementSpeed = 1;
        }

        if (col.gameObject.tag == "Worker")
        {
            GameObject.Find("Worker").GetComponent<WorkerScript>().IsCombat = false;
        }

    }
}
