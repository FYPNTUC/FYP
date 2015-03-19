using UnityEngine;
using System.Collections;

public class Lift : MonoBehaviour 
{
    public int AmountToTravel;
    public float LiftSpeed;
    public bool IsTurnBack;
    public bool IsTurning;
    private bool StartEvent;
    private bool LiftIsMoving;
    public bool PlayerInLift;
	// Use this for initialization
	void Start () 
    {
        IsTurning = false;
        IsTurnBack = false;
        LiftIsMoving = false;
	}
	
	// Update is called once per frame
    void Update()
    {
        if (PlayerInLift == true)
        {
            if (Input.GetKey("e"))
            {
                LiftIsMoving = true;
            }
        }
    }

	void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (StartEvent == true)
        {
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

        if (hit.gameObject.name == "LiftRight" || hit.gameObject.name == "LiftLeft")
        {
            //GameObject.Find("Lift").transform.Translate(Vector3.up * Time.deltaTime);

        }

        if (GameObject.Find("Lift").transform.position.y >= AmountToTravel)
        {
            LiftIsMoving = false;
            gameObject.transform.parent = null;
            StartEvent = true;
           
        }

        if (LiftIsMoving == true)
        {
            MoveTheLift();
            gameObject.transform.parent = GameObject.Find("Lift").transform;
        }

        //if (LiftIsMoving = false && StartEvent == true)
        //{
            
            
        //    GameObject.Find("Lift").gameObject.transform.eulerAngles =
        //}
       
	}

    void MoveTheLift()
    {
        GameObject.Find("Lift").transform.Translate(Vector3.up * Time.deltaTime * LiftSpeed);
    }

}
