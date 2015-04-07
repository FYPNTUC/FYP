using UnityEngine;
using System.Collections;

public class LongLadderCheck : MonoBehaviour 
{
    GameObject GUI;
    GameObject Player;
	// Use this for initialization
	void Start () 
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        GUI = GameObject.Find("GUI");
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Player.GetComponent<Lift>().PlayerNearLLadder = true;
            GUI.GetComponent<Renderer>().enabled = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Player.GetComponent<Lift>().PlayerNearLLadder = false;
            GUI.GetComponent<Renderer>().enabled = false;
        }
    }
}
