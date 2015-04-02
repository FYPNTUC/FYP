using UnityEngine;
using System.Collections;

public class CraneMover : MonoBehaviour 
{
    GameObject Platform;
    GameObject Trolley;
    GameObject Rope;
    GameObject Player;

    public bool PlatformMoving;
    bool PlatformDone;

	// Use this for initialization
	void Start () 
    {
        Platform = GameObject.Find("CraneTrigger");
        Trolley = GameObject.Find("CraneTrolleyM");
        Rope = GameObject.Find("CraneRopeM");
        Player = GameObject.FindGameObjectWithTag("Player");
        PlatformMoving = false;
        PlatformDone = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Platform.GetComponent<CranePlatform>().IsOn == true)
        {
            if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
            {
                PlatformMoving = true;
                Player.transform.parent = Platform.transform;
            }
        }

        if (PlatformMoving == true)
        {
            Rope.transform.Translate(Vector3.up * Time.deltaTime * 1f);
        }

        if (Rope.transform.position.y > 123.34)
        {
            PlatformMoving = false;
            PlatformDone = true;
        }

        if (Trolley.transform.position.x < -3)
        {
            PlatformDone = false;
            Player.transform.parent = null;
        }

        if (PlatformDone == true)
        {
            MoveTheTrolley();
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
