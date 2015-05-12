using UnityEngine;
using System.Collections;

public class Direction : MonoBehaviour
{
    GameObject Player;
    public GameObject Current;
    public GameObject Point1;
    public GameObject Point2;
    public GameObject Point3;
    public GameObject Point4;
    public GameObject Point5;
    public GameObject Point6;
    public GameObject Point7;

    public bool Done1;
    public bool Done2;
    // Use this for initialization
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Point1 = GameObject.Find("Key");
        Point2 = GameObject.Find("Building1_windowCleanerLift");
        Point3 = GameObject.Find("SWindow");
        Point4 = GameObject.Find("Building1_LadderS");
        Point5 = GameObject.Find("PlayerPassPlatform");
        Point6 = GameObject.Find("MovingPlank");
        Point7 = GameObject.Find("FlyingFoxPoleTop");
        Current = Point1;

        Done1 = false;
        Done2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Player.GetComponent<Lift>().GotKey == true && Done1 == false)
        {
            Current = Point2;
        }
        //transform.LookAt(Current.transform);
    }
}
