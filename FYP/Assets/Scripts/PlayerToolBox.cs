using UnityEngine;
using System.Collections;

public class PlayerToolBox : MonoBehaviour
{
    GameObject PlankCheckS;
    GameObject Screw1;
    GameObject Screw2;
    GameObject HammerTb;
    GameObject Player;
    GameObject BoxLoc;
    GameObject HammerP;
    Vector3 StartingLoc;
    bool IsOut;
    // Use this for initialization
    void Start()
    {
        PlankCheckS = GameObject.Find("PlankCheckS");
        HammerP = GameObject.Find("HammerP");
        Screw1 = GameObject.Find("ScrewTB1");
        Screw2 = GameObject.Find("ScrewTB2");
        HammerTb = GameObject.Find("HammerTB");
        BoxLoc = GameObject.Find("BoxLoc");
        StartingLoc = gameObject.transform.position;
        Player = GameObject.FindGameObjectWithTag("Player");
        IsOut = false;
    }

    // Update is called once per frames
    void Update()
    {
        if (IsOut == false)
        {
            if (Input.GetKeyDown("u") || Input.GetButtonDown("cButtonX"))
            {
                gameObject.transform.position = BoxLoc.transform.position;
                gameObject.transform.rotation = BoxLoc.transform.rotation;
                Player.GetComponent<OVRPlayerController>().enabled = false;
                IsOut = true;
            }
        }
        else if (IsOut == true)
        {
            if (Input.GetKeyDown("u") || Input.GetButtonDown("cButtonX"))
            {
                gameObject.transform.position = StartingLoc;
                Player.GetComponent<OVRPlayerController>().enabled = true;
                IsOut = false;
            }
        }
        if (HammerP.GetComponent<GotItem>().ObtainedH == true)
        {
            HammerTb.GetComponent<Renderer>().enabled = true;
        }
        if (PlankCheckS.GetComponent<ShakePlank>().Screw == 1)
        {
            Screw1.GetComponent<Renderer>().enabled = true;
        }

        else if (PlankCheckS.GetComponent<ShakePlank>().Screw == 2)
        {
            Screw2.GetComponent<Renderer>().enabled = true;
        }
    }
}
