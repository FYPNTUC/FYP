using UnityEngine;
using System.Collections;

public class CraneCheck : MonoBehaviour 
{
    GameObject Player;
    public bool IsCrane1;
  public  bool HoldIt;
	// Use this for initialization
	void Start () 
    {
 
        Player = GameObject.FindGameObjectWithTag("Player");
        IsCrane1 = false; ;
        HoldIt = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Player.GetComponent<CraneController>().CurrentCrane == Player.GetComponent<CraneController>().Crane3)
        {


            if (HoldIt == true)
            {
                if (Input.GetKeyDown("g") || Input.GetButtonDown("cButtonA"))
                {
                    HoldIt = false;
                    IsCrane1 = true;
                }
            }
            else if (IsCrane1 == true)
            {
                Player.transform.position = gameObject.transform.position;
                if (Input.GetKeyDown("g") || Input.GetButtonDown("cButtonA"))
                {
                    //Debug.Log("pop");
                    HoldIt = true;
                    IsCrane1 = false;
                }
            }
        }

        
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (HoldIt == false)
            {
                //Debug.Log("pls");
                IsCrane1 = true;
            }
            Player.GetComponent<CraneController>().CanBeMoved = true;
            Player.GetComponent<CraneController>().CurrentCrane = Player.GetComponent<CraneController>().Crane3;
            Player.GetComponent<CraneController>().CurrentTrolley = Player.GetComponent<CraneController>().Trolley3;
            Player.GetComponent<CraneController>().CurrentRope = Player.GetComponent<CraneController>().Rope3;
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {

            if (HoldIt == false)
            {
                //Debug.Log("pls");
                IsCrane1 = true;
            }
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            IsCrane1 = false;
            //Debug.Log("i stay");
            //Player.transform.parent = gameObject.transform;
        }
    }

    //void OnTriggerExit(Collider col)
    //{
    //    if (col.gameObject.tag == "Player")
    //    {
    //        Player.transform.parent = null;
    //    }
    //}
}
