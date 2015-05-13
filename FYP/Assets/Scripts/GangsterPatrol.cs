using UnityEngine;
using System.Collections;

public class GangsterPatrol : MonoBehaviour
{
    Animator animator;
    public bool EventStart;
    public bool NotLooking;
    GameObject Door;
    bool DoorIsMoving;
    bool DoOnce;
    public GameObject Current;
    public GameObject Point1;
    public GameObject Point2;
    public GameObject Point3;
    public GameObject Point4;

    public float Timer;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        Door = GameObject.Find("Building2_Door");
        EventStart = true;
        DoorIsMoving = false;
        DoOnce = false;
        Point1 = GameObject.Find("B2P1");
        Point2 = GameObject.Find("B2P2");
        Point3 = GameObject.Find("B2P3");
        Point4 = GameObject.Find("B2P4");
        Current = Point1;
        Timer = 5;
        NotLooking = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (EventStart == true)
        {
            if (DoOnce == false)
            {
                DoorIsMoving = true;
                DoOnce = true;
            }
        }

        if (DoorIsMoving == true)
        {
            MoveTheDoor();

        }
        if (Door.transform.eulerAngles.y <= 10 && Door.transform.eulerAngles.y >= 5)
        {
            DoorIsMoving = false;
        }
        if (DoorIsMoving == false && DoOnce == true)
        {
            gameObject.transform.LookAt(Current.transform);
            gameObject.transform.localEulerAngles = new Vector3(0, gameObject.transform.localEulerAngles.y, gameObject.transform.localEulerAngles.z);
            if (NotLooking == true)
            {
                gameObject.transform.Translate(Vector3.forward * Time.deltaTime * 3);
                animator.SetBool("IsWalking", true);
                Timer = 5;
            }
            else if (NotLooking == false)
            {
                animator.SetBool("IsWalking", false);
                animator.SetBool("IsLookingAround", true);
                Timer -= Time.deltaTime;
                if (Timer <= 0)
                {
                    NotLooking = true;
                    animator.SetBool("IsWalking", true);
                    animator.SetBool("IsLookingAround", false);
                }
            }
        }
    }
    void MoveTheDoor()
    {
        Door.transform.Rotate(Vector3.down * Time.deltaTime * 50);
    }
}
