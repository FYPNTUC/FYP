using UnityEngine;
using System.Collections;

public class CraneController : MonoBehaviour
{
    public bool CanBeMoved;

    public GameObject Crane1;
    public GameObject Crane2;
    public GameObject Crane3;
    
    public GameObject Trolley1;
    public GameObject Trolley2;
    public GameObject Trolley3;

    public GameObject Rope1;
    public GameObject Rope2;
    public GameObject Rope3;

    public GameObject CurrentCrane;
    public GameObject CurrentTrolley;
    public GameObject CurrentRope;

    public GameObject Temp;

	// Use this for initialization
	void Start () 
    {
        CanBeMoved = false;
        Crane1 = GameObject.Find("CraneArm1");
        Crane2 = GameObject.Find("CraneArm2");
        Crane3 = GameObject.Find("CraneArm3");
        Rope1 = GameObject.Find("CraneRope1");
        Rope2 = GameObject.Find("CraneRope2");
        Rope3 = GameObject.Find("CraneRope3");
        Trolley1 = GameObject.Find("CraneTrolley1");
        Trolley2 = GameObject.Find("CraneTrolley2");
        Trolley3 = GameObject.Find("CraneTrolley3");
        //Hook = GameObject.Find("CraneHook");
        Temp = GameObject.Find("Temp");
        CurrentCrane = Crane3;
        CurrentRope = Rope3;
        CurrentTrolley = Trolley3;
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (CanBeMoved == true)
        {
            //Crane Arm
            if (Input.GetKey("e"))
            {
                CurrentCrane.transform.Rotate(Vector3.down * Time.deltaTime * 10);
                //Debug.Log("cranearm has problem");
            }

            if (Input.GetAxis("cTriggers") > 0.001)
            {
                CurrentCrane.transform.Rotate(Vector3.down * Time.deltaTime * 10);
            }

            if (Input.GetKey("r"))
            {
                CurrentCrane.transform.Rotate(Vector3.up * Time.deltaTime * 10);
            }

            if (Input.GetAxis("cTriggers") < 0)
            {
                CurrentCrane.transform.Rotate(Vector3.up * Time.deltaTime * 10);
            }

            // Ropes
            //if (Input.GetKey("j"))
            //{
            //   // if (Rope.transform.localScale.y < 0.0129f)
            //    {
            //        CurrentRope.transform.localScale += new Vector3(0, 0.00010f, 0);
            //        //Hook.transform.localScale -= new Vector3(0, 0.00001f, 0);
            //    }
            //}

            //if (Input.GetKey("k"))
            //{
            //    //if (CurrentRope.transform.localScale.y > 0.0129f)
            //    {
            //        CurrentRope.transform.localScale -= new Vector3(0, 0.00010f, 0);
            //        //Hook.transform.localScale += new Vector3(0, 0.00001f, 0);
            //    }
            //}

            //Trolley
            if (Input.GetKey("p"))
            {
                CurrentTrolley.transform.Translate(Vector3.left * Time.deltaTime * 3);
            }

            if (Input.GetButton("cLeftBumper"))
            {
                CurrentTrolley.transform.Translate(Vector3.left * Time.deltaTime * 3);
            }

            if (Input.GetKey("o"))
            {

                CurrentTrolley.transform.Translate(Vector3.right * Time.deltaTime * 3);
            }

            if (Input.GetButton("cRightBumper"))
            {
                CurrentTrolley.transform.Translate(Vector3.right * Time.deltaTime * 3);
            }
        }

	}
}
