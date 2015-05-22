using UnityEngine;
using System.Collections;

public class CraneCheck2 : MonoBehaviour 
{

    GameObject Player;
    bool IsCrane2;
    bool HoldIt;
    bool DoOnce;
    GameObject ResetLocationC2;
    //GameObject CraneController;

    // Use this for initialization
    void Start()
    {
        ResetLocationC2 = GameObject.Find("ResetLocationC2");
        DoOnce = false;
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
                if (Input.GetKeyDown("g") || Input.GetButtonDown("cButtonA"))
                {
                    Player.GetComponent<CraneController>().CanBeMoved = true;
                    HoldIt = false;
                    IsCrane2 = true;
                }
            }
            else if (IsCrane2 == true)
            {
                Vector3 temp;
                temp = gameObject.transform.position;
                temp.y += 0.8f;
                Player.transform.position = temp;
                if (Input.GetKeyDown("g") || Input.GetButtonDown("cButtonA"))
                {
                    Player.GetComponent<CraneController>().CanBeMoved = false;
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
            if (DoOnce == false)
            {
                Player.GetComponent<CraneController>().CanBeMoved = true;
                DoOnce = true;
            }
            Player.GetComponent<CraneController>().CurrentCrane = Player.GetComponent<CraneController>().Crane2;
            Player.GetComponent<CraneController>().CurrentTrolley = Player.GetComponent<CraneController>().Trolley2;
            Player.GetComponent<CraneController>().CurrentRope = Player.GetComponent<CraneController>().Rope2;
            Player.GetComponent<FadeInOut>().ResetLocation = ResetLocationC2;
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
