using UnityEngine;
using System.Collections;

public class CraneMover : MonoBehaviour 
{
    GameObject Platform;
    GameObject Trolley;
    GameObject Rope;
    GameObject Player;
    GameObject Checker;

    public bool PlatformMoving;
    bool PlatformDone;
    bool StopPls;

	// Use this for initialization
	void Start () 
    {
        Platform = GameObject.Find("CraneTrigger");
        Trolley = GameObject.Find("CraneTrolleyM");
        Rope = GameObject.Find("CraneRopeM");
        Player = GameObject.FindGameObjectWithTag("Player");
        PlatformMoving = false;
        PlatformDone = false;
        Checker = GameObject.Find("CraneTrigger");
        StopPls = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (StopPls == false)
        {
            if (Platform.GetComponent<CranePlatform>().IsOn == true)
            {
                if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
                {
                    PlatformMoving = true;
                    Player.transform.parent = Platform.transform;
                    Checker.GetComponent<BoxCollider>().enabled = false;
                    GameObject.Find("GUI").GetComponent<Renderer>().enabled = false;
                    Platform.GetComponent<CranePlatform>().IsOn = false;
                    Debug.Log("cranemover has problem");

                }
            }

            if (Trolley.transform.position.x < -3)
            {
                PlatformDone = false;
                Player.transform.parent = null;
                StopPls = true;
            }


            if (PlatformMoving == true)
            {
                Rope.transform.Translate(Vector3.up * Time.deltaTime * 1f);
            }

            if (PlatformDone == true)
            {
                MoveTheTrolley();
            }
        }


        if (Rope.transform.position.y > 123.34)
        {
            PlatformMoving = false;
            PlatformDone = true;
        }

       

      
	}

    void MoveThePlatForm()
    {
        Rope.transform.Translate(Vector3.up * Time.deltaTime * 0.1f);
    }

    void MoveTheTrolley()
    {
        Trolley.transform.Translate(Vector3.right * Time.deltaTime * 1f);
    }
}
