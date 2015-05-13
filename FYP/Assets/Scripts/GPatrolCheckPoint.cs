using UnityEngine;
using System.Collections;

public class GPatrolCheckPoint : MonoBehaviour 
{
    GameObject Gangster;
   // float Timer;
	// Use this for initialization
	void Start () 
    {
        Gangster = GameObject.Find("GangsterPat");
        //Timer = 3;

	}
	
	// Update is called once per frame
	void Update () 
    {
	    
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == ("PG"))
        {
            
            if (gameObject.name == "B2P1")
            {
                Gangster.GetComponent<GangsterPatrol>().NotLooking = false;
                //Timer -= Time.deltaTime;
                //if (Timer <= 0)
                //{
                //     Gangster.GetComponent<GangsterPatrol>().NotLooking = true;
                //   Timer = 3;
                //}
                Gangster.GetComponent<GangsterPatrol>().Current = Gangster.GetComponent<GangsterPatrol>().Point2;
            }

            if (gameObject.name == "B2P2")
            {
                Gangster.GetComponent<GangsterPatrol>().NotLooking = false;
                Gangster.GetComponent<GangsterPatrol>().Current = Gangster.GetComponent<GangsterPatrol>().Point3;
            }

            if (gameObject.name == "B2P3")
            {
                Gangster.GetComponent<GangsterPatrol>().NotLooking = false;
                Gangster.GetComponent<GangsterPatrol>().Current = Gangster.GetComponent<GangsterPatrol>().Point4;
            }

            if (gameObject.name == "B2P4")
            {
                Gangster.GetComponent<GangsterPatrol>().NotLooking = false;
                Gangster.GetComponent<GangsterPatrol>().Current = Gangster.GetComponent<GangsterPatrol>().Point1;
            }
        }
    }

}
