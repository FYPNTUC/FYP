using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour
{
    public float XMoveSpeed;
    public float YMoveSpeed;
    public float HowMuchToMoveX;
    public float HowMuchToMoveY;

    bool MoveAway;
    bool MoveBack;

    float TempX;
    float TempMB;
    public float counter;
    private float timer;
    bool IsMoving;
    // Use this for initialization
    void Start()
    {
        TempX = transform.position.x - HowMuchToMoveX;
        TempMB = transform.position.x; 
        timer = 0;
        IsMoving = false;
        MoveAway = true;
        MoveBack = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer = Time.deltaTime + timer;

        if (timer > counter)
        {

            timer = 0;
            IsMoving = true;
        }

        if (IsMoving == true)
        {
            MoveThePlatform();
        }
    }

    
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.gameObject.name == "First Person Controller")
        {
            col.transform.parent = gameObject.transform;
            //col.GetComponent<>
            Debug.Log("hit");
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "First Person Controller")
        {
            col.transform.parent =null;
            Debug.Log("hit");
        }
    }

    void MoveThePlatform()
    {
        if (transform.position.x > TempX && MoveAway == true)
        {
            transform.Translate(Vector3.left * XMoveSpeed * Time.deltaTime);
           // Debug.Log(transform.position.x);
        }

        if (transform.position.x < TempX)
        {
            MoveAway = false;
            MoveBack = true;
        }

        if (transform.position.x <= TempMB && MoveBack == true)
        {
            transform.Translate(Vector3.right * XMoveSpeed * Time.deltaTime);
           // Debug.Log(transform.position.x);
        }

        if (transform.position.x > TempMB)
        {  
            MoveAway = true;
            MoveBack = false;
        }
    }




}
