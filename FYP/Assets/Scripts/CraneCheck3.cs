using UnityEngine;
using System.Collections;

public class CraneCheck3 : MonoBehaviour 
{

    GameObject Player;
    public bool IsCrane3;
    bool HoldIt;
    bool AllDone;
    bool DoOnce;
    GameObject ResetLocationC3;
    //GameObject CraneController;

    // Use this for initialization
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        ResetLocationC3 = GameObject.Find("ResetLocationC3");
        IsCrane3 = false;
        HoldIt = false;
        AllDone = false;
        DoOnce = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HoldIt == true)
        {
            if (Input.GetKeyDown("g") || Input.GetButtonDown("cButtonA"))
            {
                Player.GetComponent<CraneController>().CanBeMoved = true;
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
            if (Input.GetKeyDown("g") || Input.GetButtonDown("cButtonA"))
            {
                Player.GetComponent<CraneController>().CanBeMoved = false;
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
            if (DoOnce == false)
            {
                Player.GetComponent<CraneController>().CanBeMoved = true;
                DoOnce = true;
            }
            Player.GetComponent<CraneController>().CurrentCrane = Player.GetComponent<CraneController>().Crane1;
            Player.GetComponent<CraneController>().CurrentTrolley = Player.GetComponent<CraneController>().Trolley1;
            Player.GetComponent<CraneController>().CurrentRope = Player.GetComponent<CraneController>().Rope1;
            Player.GetComponent<FadeInOut>().ResetLocation = ResetLocationC3;

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
