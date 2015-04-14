using UnityEngine;
using System.Collections;

public class MoveTheCars : MonoBehaviour 
{
    GameObject LCars;
    GameObject LTrucks;
    GameObject RCars;
    GameObject RTrucks;
    GameObject LCars2;
    GameObject LTrucks2;
    GameObject RCars2;
    GameObject RTrucks2;

	// Use this for initialization
	void Start () 
    {
        LCars = GameObject.Find("LeftSideCar");
        LTrucks = GameObject.Find("LeftSideTruck");
        RCars = GameObject.Find("RightSideCar");
        RTrucks = GameObject.Find("RightSideTruck");
        LCars2 = GameObject.Find("LeftSideCar2");
        LTrucks2 = GameObject.Find("LeftSideTruck2");
        RCars2 = GameObject.Find("RightSideCar2");
        RTrucks2 = GameObject.Find("RightSideTruck2");
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (LCars.transform.position.z > 350)
        {
            LCars.transform.Translate(0, 0, -550);
        }

        if (LCars2.transform.position.z > 350)
        {
            LCars2.transform.Translate(0, 0, -750);
        }


        if (LTrucks.transform.position.z > 350)
        {
            LTrucks.transform.Translate(0, 0, -650);
        }

        if (LTrucks2.transform.position.z > 350)
        {
            LTrucks2.transform.Translate(0, 0, -850);
        }

        if (RCars.transform.position.z < -600)
        {
            RCars.transform.Translate(0, 0, 850);
        }

        if (RCars2.transform.position.z < -600)
        {
            RCars2.transform.Translate(0, 0, 1050);
        }

        if (RTrucks.transform.position.z < -600)
        {
            RTrucks.transform.Translate(0, 0, 850);
        }

        if (RTrucks2.transform.position.z < -600)
        {
            RTrucks2.transform.Translate(0, 0, 1050);
        }

            
        MoveTheLCars();
        MoveTheLTrucks();
        MoveTheRCars();
        MoveTheRTrucks();
        MoveTheLCars2();
        MoveTheLTrucks2();
        MoveTheRCars2();
        MoveTheRTrucks2();

       
	}

    void MoveTheLCars()
    {
        LCars.transform.Translate(Vector3.forward * Time.deltaTime * 50);
        
    }

    void MoveTheRCars()
    {
        RCars.transform.Translate(Vector3.back * Time.deltaTime * 50);
        Debug.Log(RCars.transform.position.z);
    }

    void MoveTheLTrucks()
    {
        LTrucks.transform.Translate(Vector3.forward * Time.deltaTime * 25);
    }

    void MoveTheRTrucks()
    {
        RTrucks.transform.Translate(Vector3.back * Time.deltaTime * 25);
    }

    void MoveTheLCars2()
    {
        LCars2.transform.Translate(Vector3.forward * Time.deltaTime * 50);
        //Debug.Log(LCars.transform.position.z);
    }

    void MoveTheRCars2()
    {
        RCars2.transform.Translate(Vector3.back * Time.deltaTime * 50);
    }

    void MoveTheLTrucks2()
    {
        LTrucks2.transform.Translate(Vector3.forward * Time.deltaTime * 25);
    }

    void MoveTheRTrucks2()
    {
        RTrucks2.transform.Translate(Vector3.back * Time.deltaTime * 25);
    }
}
