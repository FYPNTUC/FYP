using UnityEngine;
using System.Collections;

public class CraneClimbCheck : MonoBehaviour 
{
    GameObject GUI;
    GameObject Player;
    bool CanClimb;
	// Use this for initialization
	void Start () 
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        GUI = GameObject.Find("GUI");
        CanClimb = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (CanClimb == true)
        {
            if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<FadeInOut>().ResetLocation = GameObject.Find("ResetLocationC");
                GameObject.FindGameObjectWithTag("Player").GetComponent<FadeInOut>().ChangeLevelFade = true;
            }
        }
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            GUI.GetComponent<Renderer>().enabled = true;
            CanClimb = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            GUI.GetComponent<Renderer>().enabled = false;
            CanClimb = false;
        }
    }
}
