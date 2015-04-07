using UnityEngine;
using System.Collections;

public class PlayerInLift : MonoBehaviour 
{
    GameObject GUI;

	// Use this for initialization
	void Start () 
    {
        GUI = GameObject.Find("GUI");
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag=="Player") 
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Lift>().PlayerInLift = true;
            GUI.GetComponent<Renderer>().enabled = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Lift>().PlayerInLift = false;
            GUI.GetComponent<Renderer>().enabled = false;
        }
    }
}
