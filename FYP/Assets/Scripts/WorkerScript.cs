using UnityEngine;
using System.Collections;

public class WorkerScript : MonoBehaviour
{
    Animator animator;
    public bool IsHammering;
    public bool IsMoving;
    public bool IsFalling;
    public bool IsCombat;
    public bool IsHit;

    float timer;

    public GameObject CurrentPoint;
    GameObject PointA;
    GameObject PointB;
    float MovementSpeed;
    Vector3 Temp;
    // Use this for initialization
    void Start()
    {
        IsFalling = false;
        IsHammering = false;
        IsMoving = true;
        IsCombat = false;
        IsHit = false;

        animator = GetComponent<Animator>();
        MovementSpeed = 1;
        timer = 7;
        PointA = GameObject.Find("PointA");
        PointB = GameObject.Find("PointB");
        CurrentPoint = PointA;
        Temp = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //if (gameObject.GetComponent<CharacterController>().isGrounded == false)
        //{
        //    IsFalling = true;
        //}
        if (IsFalling == true)
        {
            IsMoving = false;
            animator.SetBool("IsWalking", false);
            animator.SetBool("IsHammering", false);
            animator.SetBool("IsFalling", true);

        }
        else if (IsFalling == false)
        {
            if (IsHit == true)
            {
                IsFalling = false;
                IsHammering = false;
                IsMoving = false;
                IsCombat = false;

                animator.SetBool("IsWalking", false);
                animator.SetBool("IsHammering", false);
                animator.SetBool("IsFalling", false);
                animator.SetBool("IsGuard", false);
                animator.SetBool("IsHit", true  );
                
            }
            if (IsCombat == true)
            {
                animator.SetBool("IsWalking", false);
                animator.SetBool("IsHammering", false);
                animator.SetBool("IsFalling", false);
                animator.SetBool("IsGuard", true);
                IsMoving = false;
                IsHammering = false;
            }
            else if (IsCombat == false)
            {
                animator.SetBool("IsGuard", false);
            }
            if (IsMoving == true)
            {

                animator.SetBool("IsWalking", true);
                transform.LookAt(CurrentPoint.transform);
                transform.Translate(Vector3.forward * Time.deltaTime * MovementSpeed);
                gameObject.transform.localEulerAngles = new Vector3(0, gameObject.transform.localEulerAngles.y, gameObject.transform.localEulerAngles.z);
                transform.position = new Vector3(transform.position.x, Temp.y, transform.position.z);
            }

            else if (IsMoving == false)
            {
                gameObject.transform.localEulerAngles = new Vector3(0, 0, 0);
                animator.SetBool("IsWalking", false);
            }

            if (IsHammering == true)
            {
                animator.SetBool("IsHammering", true);
                timer -= Time.deltaTime;
                //Debug.Log(timer);
                if (timer <= 0)
                {
                    IsHammering = false;
                    timer = 7;
                }
            }

            else if (IsHammering == false && IsMoving == false)
            {
                animator.SetBool("IsHammering", false);
                if (CurrentPoint == PointA)
                {
                    CurrentPoint = PointB;
                }

                else if (CurrentPoint == PointB)
                {
                    CurrentPoint = PointA;
                }
                IsMoving = true;
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        print("rekt");
        if (col.gameObject.tag == "Gangster")
        {
            IsHit = true;
        }
    }


}
