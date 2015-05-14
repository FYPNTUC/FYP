using UnityEngine;
using System.Collections;

public class FallChecker : MonoBehaviour 
{
    GameObject Worker;
	// Use this for initialization
	void Start () 
    {
        Worker = GameObject.Find("FallingWorker");
	}
	
	// Update is called once per frame
	void Update () 
    {
	    
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
                Worker.GetComponent<FallAi>().BeingHelped = true;
            }
        }
    }

    //void OnTriggerExit(Collider col)
    //{
    //    if (col.gameObject.tag == "Player")
    //    {
    //        IsFollowing = false;
    //    }
    //}
}
