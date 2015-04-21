using UnityEngine;
using System.Collections;

public class Lift : MonoBehaviour
{
    public GameObject ShatteredGlass;
    public GameObject ShatteredScaff;
    GameObject CheckPlayer;
    GameObject Rope;
    public Animator anim;
    public int AmountToTravel;
    public float LiftSpeed;
    public bool IsTurnBack;
    public bool IsTurning;
    public bool StartEvent;
    public bool LiftIsMoving;
    public bool PlayerInLift;
    public bool PlayerNearLadder;
    public bool PlayerNearLLadder;
    public bool PlayerNearCraneL;
    public bool LimitReached;
    public bool LimitReachedL;
    public bool GotKey;
    public int NoOfScrew;
    bool DoOnce;
    // Use this for initialization
    void Start()
    {
        //ShatteredGlass = 
        PlayerNearCraneL = false;
        NoOfScrew = 0;
        anim = GameObject.Find("Lift").GetComponent<Animator>();
        IsTurning = false;
        IsTurnBack = false;
        LiftIsMoving = false;
        StartEvent = false;
        DoOnce = false;
        PlayerNearLadder = false;
        PlayerNearLLadder = false;
        LimitReached = false;
        LimitReachedL = false;
        CheckPlayer = GameObject.Find("CheckPlayer");
        Rope = GameObject.Find("RopeLeft");
        GotKey = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GotKey == true)
        {
            if (PlayerInLift == true)
            {
                if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
                {
                    LiftIsMoving = true;
                    Destroy(CheckPlayer);
                    GameObject.Find("GUI").GetComponent<Renderer>().enabled = false;
                    //Debug.Log("lift has problem");
                }
            }
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == ("BreakableG"))
        {
            Vector3 temp;
            temp = hit.transform.position;
            temp.y -= 1;
            Destroy(hit.gameObject);
            Instantiate(ShatteredGlass, temp, Quaternion.identity);
            GameObject.Find("Glass").transform.position = transform.position;
            GameObject.Find("Glass").GetComponent<AudioSource>().Play();//    .enabled = true;
        }
        if (hit.gameObject.tag == ("Breakable"))
        {
            Vector3 temp;
            temp = hit.transform.position;
            Destroy(hit.gameObject);
            Instantiate(ShatteredScaff, temp, Quaternion.identity);
        }
        if (StartEvent == true)
        {
            //anim.enabled = true;
            if (LimitReached == false)
            {
                if (hit.gameObject.name == "LiftRight")
                {
                    IsTurning = true;
                    IsTurnBack = false;
                }
            }

            if (LimitReachedL == false)
            {
                if (hit.gameObject.name == "LiftLeft")// && IsTurning == true)
                {
                    IsTurning = false;
                    IsTurnBack = true;
                }
            }
            Destroy(Rope);
        }

        if (GameObject.Find("PlayerInBuildingTrigger").GetComponent<PlayerEnteredBuilding>().PlayerIsInBuilding == false)
        {
            //if (hit.gameObject.name == "LiftRight" || hit.gameObject.name == "LiftLeft")
            //{
            //    //GameObject.Find("Lift").transform.Translate(Vector3.up * Time.deltaTime);

            //}

            if (GameObject.Find("Lift").transform.position.y >= AmountToTravel)
            {
                LiftIsMoving = false;
                StartEvent = true;
               
                gameObject.transform.parent = null;
               

                if (DoOnce == false)
                {
                    gameObject.transform.Translate(0.1f, 0, 0);
                    GameObject.Find("PlayerModel").transform.localScale = new Vector3(1,1,1);
                }

                DoOnce = true;
            
            };

            if (LiftIsMoving == true)
            {
                MoveTheLift();
                gameObject.transform.parent = GameObject.Find("Lift").transform;
            }
        }

    }

    void MoveTheLift()
    {
        GameObject.Find("Lift").transform.Translate(Vector3.up * Time.deltaTime * LiftSpeed);
    }

}
