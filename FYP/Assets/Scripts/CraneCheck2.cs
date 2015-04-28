using UnityEngine;
using System.Collections;

public class CraneCheck2 : MonoBehaviour 
{

    GameObject Player;
    bool IsCrane2;
    bool HoldIt;
    //GameObject CraneController;

    // Use this for initialization
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        IsCrane2 = false;
        HoldIt = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.GetComponent<CraneController>().CurrentCrane == Player.GetComponent<CraneController>().Crane2)
        {
            if (HoldIt == true)
            {
                if (Input.GetKey("g") || Input.GetButtonDown("cButtonA"))
                {
                    HoldIt = false;
                    IsCrane2 = true;
                }
            }
            else if (IsCrane2 == true)
            {
                Player.transform.position = gameObject.transform.position;
                if (Input.GetKey("g") || Input.GetButtonDown("cButtonA"))
                {
                    HoldIt = true;
                    IsCrane2 = false;
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
                IsCrane2 = true;
            }
            Player.GetComponent<CraneController>().CurrentCrane = Player.GetComponent<CraneController>().Crane2;
            Player.GetComponent<CraneController>().CurrentTrolley = Player.GetComponent<CraneController>().Trolley2;
            Player.GetComponent<CraneController>().CurrentRope = Player.GetComponent<CraneController>().Rope2;

        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {

            if (HoldIt == false)
            {
                //Debug.Log("pls");
                IsCrane2 = true;
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        IsCrane2 = false;
    }
}
