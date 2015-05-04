using UnityEngine;
using System.Collections;

public class AICheckPoint : MonoBehaviour 
{
    public GameObject Worker;

	// Use this for initialization
	void Start () 
    {
        Worker = GameObject.Find("Worker");
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnTriggerEnter(Collider col)
    {
        //print("wowow");
        if (col.gameObject.tag == "Worker")
        {
          
            Worker.GetComponent<WorkerScript>().IsMoving = false;
            Worker.GetComponent<WorkerScript>().IsHammering = true;

        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Worker")
        {
         
        }
    }
}
