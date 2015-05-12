using UnityEngine;
using System.Collections;

public class Lift : MonoBehaviour
{
    GameObject CS;
    //GameObject Gangster2;
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
    Vector3 TempP;
    bool DoOnce;
    // Use this for initialization
    void Start()
    {
        //force the application to 75 fps
        Application.targetFrameRate = 75;
        CS = GameObject.Find("CutScene");
        //Gangster2 = GameObject.Find("Gangster2");
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

        //ovrHmd_GetTrackingState
       
        
        //allow the player to recenter the camera
        if (Input.GetButtonDown("cButtonBack"))
        {
            OVRManager.display.RecenterPose();
            //Debug.Log("pop");
        }
        //if the player has the key and is in the lift
        if (GotKey == true)
        {
            if (PlayerInLift == true)
            {
                if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
                {

                    GameObject.Find("Arrow").GetComponent<Direction>().Done1 = true;
                    GameObject.Find("Arrow").GetComponent<Direction>().Current =  GameObject.Find("Arrow").GetComponent<Direction>().Point3;
                    //play the insert key animation
                    GameObject.Find("PlayerModel").GetComponent<Animation>().Play("InsertKey");
                    //store the lift's starting position
                    TempP = gameObject.transform.position;
                    //starts the lift 
                    LiftIsMoving = true;
                    //destroy the player checker
                    Destroy(CheckPlayer);
                    //deactivate the gui
                    GameObject.Find("GUI").GetComponent<Renderer>().enabled = false;
                    //Debug.Log("lift has problem");
                }


            }
        }
    }

    //super costly do not use if possible as it check with everything the player hit
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //if (hit.gameObject.name == "L_Palm" || hit.gameObject.name == "R_Wrist 1" || hit.gameObject.name == "L_Feet1" || hit.gameObject.name == "R_Feet1")
        //{ 

        //}

        //when the lift has reached the set height
        if (StartEvent == true)
        {
            //when the max tilt is not reached && standing on the correct area
            if (LimitReached == false)
            {
                if (hit.gameObject.name == "LiftRight")
                {
                    IsTurning = true;
                    IsTurnBack = false;
                }
            }
            //when the max tilt is not reached && standing on the correct area
            if (LimitReachedL == false)
            {
                if (hit.gameObject.name == "LiftLeft")// && IsTurning == true)
                {
                    IsTurning = false;
                    IsTurnBack = true;
                }
            }
            //destroy the rope make the lift fall on one side and destroy the gangsters as they are not longer needed
            Destroy(Rope);
            Destroy(CS);
           
        }

        if (GameObject.Find("PlayerInBuildingTrigger").GetComponent<PlayerEnteredBuilding>().PlayerIsInBuilding == false)
        {
            //if (hit.gameObject.name == "LiftRight" || hit.gameObject.name == "LiftLeft")
            //{
            //    //GameObject.Find("Lift").transform.Translate(Vector3.up * Time.deltaTime);

            //}

            //if the lift travel the set distance stop the lift from moving up and start the tilting
            if (GameObject.Find("Lift").transform.position.y >= AmountToTravel)
            {
                LiftIsMoving = false;
                StartEvent = true;
                PlayerInLift = false;
                //to make the player not move weirdly
                if (DoOnce == false)
                {
                    gameObject.transform.Translate(0.1f, 0, 0);
                    //GameObject.Find("PlayerModel").transform.localScale = new Vector3(1,1,1);
                }

                DoOnce = true;

            };
            //move the lift upwards
            if (LiftIsMoving == true)
            {
                Vector3 temp;
                temp = GameObject.Find("Lift").transform.position;
                temp.y += 0.3f;
                temp.x = TempP.x;
                MoveTheLift();

            }
        }

    }

    void MoveTheLift()
    {
        //move the lift along with the player so that the player camera wont be bumpy
        GameObject.Find("Lift").transform.Translate(Vector3.up * Time.deltaTime * LiftSpeed);
        gameObject.transform.Translate(Vector3.up * Time.deltaTime * LiftSpeed);
    }

}
