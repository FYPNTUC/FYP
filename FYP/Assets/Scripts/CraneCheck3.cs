using UnityEngine;
using System.Collections;

public class CraneCheck3 : MonoBehaviour 
{

    GameObject Player;
    bool IsCrane3;
    bool HoldIt;
    bool AllDone;
    //GameObject CraneController;

    // Use this for initialization
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        IsCrane3 = false;
        HoldIt = false;
        AllDone = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HoldIt == true)
        {
            if (Input.GetKey("g") || Input.GetButtonDown("cButtonA"))
            {
                HoldIt = false;
                IsCrane3 = true;
            }
        }

        else if  (IsCrane3 == true)
        {
            Vector3 temp;
            temp = gameObject.transform.position;
            temp.y += 0.6f;
            Player.transform.position = temp;
            if (Input.GetKey("g") || Input.GetButtonDown("cButtonA"))
            {
                HoldIt = true;
                IsCrane3 = false;
            }
        }

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (HoldIt == false)
            {
                IsCrane3 = true;
            }
            Player.GetComponent<CraneController>().CurrentCrane = Player.GetComponent<CraneController>().Crane1;
            Player.GetComponent<CraneController>().CurrentTrolley = Player.GetComponent<CraneController>().Trolley1;
            Player.GetComponent<CraneController>().CurrentRope = Player.GetComponent<CraneController>().Rope1;

        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {

            if (HoldIt == false)
            {
                //Debug.Log("pls");
                IsCrane3 = true;
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            IsCrane3 = false;
        }
    }
}
