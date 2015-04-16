using UnityEngine;
using System.Collections;

public class BoxCheck : MonoBehaviour 
{
    GameObject GUI;
    GameObject Box;
	// Use this for initialization
	void Start () 
    {
        GUI = GameObject.Find("GUI");
        Box = GameObject.Find("MoveAbleBox");
	}
	
	// Update is called once per frame
	void Update () 
    {
	    
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            GUI.renderer.enabled = true;
            Box.GetComponent<MoveUpBox>().CanMove = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            GUI.renderer.enabled = false;
            Box.GetComponent<MoveUpBox>().CanMove = false;
        }
    }
}
