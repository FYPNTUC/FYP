using UnityEngine;
using System.Collections;

public class AICheckPoint : MonoBehaviour
{
    public GameObject Worker;
    int x;
     float Timer;
      
    // Use this for initialization
    void Start()
    {
        Timer = 1;
        x = 0;
        Worker = GameObject.Find("Worker");
    }

    // Update is called once per frame
    void Update() 
    {
       
        //Timer -= Time.deltaTime;
        //if (Timer <= 0)
        //{
        //    x = (Random.Range(1, 10));      
        //    Timer = 1;
        //    Debug.Log(x);      
        //}
	}

    void OnTriggerEnter(Collider col)
    {
        // check if its worker 
        if (col.gameObject.tag == "Worker")
        {
            //stop the walking animation and start the hammering animation
            Worker.GetComponent<WorkerScript>().IsMoving = false;
            Worker.GetComponent<WorkerScript>().IsHammering = true;
        }
        if (col.gameObject.tag == "CSG1" || col.gameObject.tag == "CSG2" || col.gameObject.tag =="CSW2")
        {
            col.GetComponent<StartScript>().Part1Done = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Worker")
        {

        }
    }
}












