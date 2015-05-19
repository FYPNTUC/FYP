using UnityEngine;
using System.Collections;

public class CraneController : MonoBehaviour
{
    public bool CanBeMoved;
    GameObject CController;
    Vector3 CLocation;
    GameObject BoxLoc;
    GameObject PlayerModel;

    public GameObject Player;
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

    bool IsMoving;
    bool DoOnce;
    bool DoOnce2;
    bool IsOut;
    GameObject Turning1;
    float Timer;

	// Use this for initialization
	void Start () 
    {
        Timer = 1;
        IsOut = false;
        DoOnce2 = false;
        PlayerModel = GameObject.Find("PlayerModel");
        CController = GameObject.Find("CraneController");
        CLocation = CController.transform.position;
        BoxLoc = GameObject.Find("CLoc");
        DoOnce = false;
        IsMoving = false;
        Turning1 = GameObject.Find("CraneTurn1");
        Player = GameObject.FindGameObjectWithTag("Player");
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
        if (IsMoving == true)
        {
            if (DoOnce == false)
            {
                Turning1.GetComponent<AudioSource>().Play();
                DoOnce = true;
            }
            if (Turning1.GetComponent<AudioSource>().isPlaying == false)
            {
                DoOnce = false;
            }
        }
        if (CanBeMoved == true)
        {
            if (DoOnce2 == false)
            {
                PlayerModel.GetComponent<Animation>().Play("TakeOutCraneController");
                PlayerModel.GetComponent<Animation>().PlayQueued("HoldingControllerIdle");
                IsOut = true;
                DoOnce2 = true;
            }
            PlayerModel.GetComponent<CharacterAnim>().IsOnCrane = true;
            Timer -= Time.deltaTime;
            if (Timer <= 0)
            {
                CController.transform.position = BoxLoc.transform.position;
                CController.transform.rotation = BoxLoc.transform.rotation;
                CController.transform.parent = BoxLoc.transform;
                Timer = 1;
            }
            //Crane Arm
            if (Input.GetKey("e"))
            {
                //Player.transform.position = curre
                CurrentCrane.transform.Rotate(Vector3.down * Time.deltaTime * 10);
                IsMoving = true;
                //Debug.Log("cranearm has problem");
            }

            if (Input.GetAxis("cTriggers") > 0.001)
            {
                CurrentCrane.transform.Rotate(Vector3.down * Time.deltaTime * 10);
                IsMoving = true;
            }

            if (Input.GetKey("r"))
            {
                CurrentCrane.transform.Rotate(Vector3.up * Time.deltaTime * 10);
                IsMoving = true;
            }

            if (Input.GetAxis("cTriggers") < 0)
            {
                CurrentCrane.transform.Rotate(Vector3.up * Time.deltaTime * 10);
                IsMoving = true;
            }

            else
            {
                IsMoving = false;
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
                IsMoving = true;
            }

            if (Input.GetButton("cLeftBumper"))
            {
                CurrentTrolley.transform.Translate(Vector3.left * Time.deltaTime * 3);
                IsMoving = true;
            }

            if (Input.GetKey("o"))
            {

                CurrentTrolley.transform.Translate(Vector3.right * Time.deltaTime * 3);
                IsMoving = true;
            }

            if (Input.GetButton("cRightBumper"))
            {
                CurrentTrolley.transform.Translate(Vector3.right * Time.deltaTime * 3);
                IsMoving = true;
            }
        }

        else if (CanBeMoved == false && IsOut == true)
        {
            PlayerModel.GetComponent<Animation>().Play("PutBackController");
            CController.transform.parent = null;
            CController.transform.position = CLocation;
            PlayerModel.GetComponent<CharacterAnim>().IsOnCrane = false;
            DoOnce2 = false;
            IsOut = false;
            //print("pop");
        }

	}
}
