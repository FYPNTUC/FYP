using UnityEngine;
using System.Collections;

public class FallChecker : MonoBehaviour 
{
    GameObject Worker;
    GameObject GUI;
    bool CanHelp;
	// Use this for initialization
	void Start () 
    {
        Worker = GameObject.Find("FallingWorker");
        GUI = GameObject.Find("GUI");
        CanHelp = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (CanHelp == true)
        {
            if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
            {
                //print("GFD");
                Worker.GetComponent<FallAi>().BeingHelped = true;
                GUI.GetComponent<Renderer>().enabled = false;
                Destroy(gameObject);
            }          
        }
	}

    void OnTriggerEnter(Collider col)
    {
        if (gameObject.name == "FallChecker")
        {
            if (col.gameObject.tag == "Player")
            {
                Worker.GetComponent<FallAi>().Fall = true;
            }
        }

        if (gameObject.name == "FallChecker2")
        {
            if (col.gameObject.tag == "Player")
            {
                GUI.GetComponent<Renderer>().enabled = true;
                CanHelp = true;
                   
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            GUI.GetComponent<Renderer>().enabled = false;
        }
    }
}
