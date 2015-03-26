using UnityEngine;
using System.Collections;

public class Lift : MonoBehaviour
{
    public Animator anim;
    public int AmountToTravel;
    public float LiftSpeed;
    public bool IsTurnBack;
    public bool IsTurning;
    public bool StartEvent;
    public bool LiftIsMoving;
    public bool PlayerInLift;
    // Use this for initialization
    void Start()
    {
        anim = GameObject.Find("Lift").GetComponent<Animator>();
        IsTurning = false;
        IsTurnBack = false;
        LiftIsMoving = false;
        StartEvent = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerInLift == true)
        {
            if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
            {
                LiftIsMoving = true;
            }
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == ("Breakable"))
        {
            Destroy(hit.gameObject);
        }
        if (StartEvent == true)
        {
            //anim.enabled = true;

            if (hit.gameObject.name == "LiftRight")
            {
                IsTurning = true;
                IsTurnBack = false;
            }

            if (hit.gameObject.name == "LiftLeft" && IsTurning == true)
            {
                IsTurning = false;
                IsTurnBack = true;
            }
        }

        if (GameObject.Find("PlayerEnteredBuilding").GetComponent<PlayerEnteredBuilding>().PlayerIsInBuilding == false)
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
                gameObject.transform.Translate(0.01f, 0.01f, 0.01f);
            }

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
