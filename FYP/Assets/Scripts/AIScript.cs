using UnityEngine;
using System.Collections;

public class AIScript : MonoBehaviour 
{
    
    Animator animator;
    public GameObject Player;
    public GameObject PlayerModel;
    public bool Combat;
    public bool IsFollowing;
    public float MovementSpeed;
    Vector3 Temp;
    //IsFight IsTalking IsWalking IsLookingAround IsGuarding IsRuning

	// Use this for initialization
	void Start () 
    {
        MovementSpeed = 1;
        animator = GetComponent<Animator>();
        animator.SetBool("IsLookingAround", true);
        Player = GameObject.FindGameObjectWithTag("Player");
        PlayerModel = GameObject.Find("PlayerModel");
        IsFollowing = false;
        Combat = false;
        Temp = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
    {
       

        if (IsFollowing == true)
        {  
            animator.SetBool("IsGuarding", false);
            animator.SetBool("IsFight", false);
            animator.SetBool("IsWalking", true);
            animator.SetBool("IsLookingAround", false);         
            transform.LookAt(PlayerModel.transform);
            //transform.position = Temp;
            transform.Translate ( Vector3.forward * Time.deltaTime * MovementSpeed);
            transform.position = new Vector3(transform.position.x, Temp.y,transform.position.z);
        }

        else if (IsFollowing == false)
        {
            gameObject.transform.localEulerAngles = new Vector3(0, 0, 0);
        }

        if (Combat == true)
        {
            MovementSpeed = 0.1f;
            animator.SetBool("IsLookingAround", false);
            animator.SetBool("IsWalking", false);
            animator.SetBool("IsGuarding", true);
            animator.SetBool("IsFight", true);
        }

        else if  (IsFollowing == false)
        {
            animator.SetBool("IsWalking", false);
            animator.SetBool("IsLookingAround", true);
        }
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            IsFollowing = true;
        }

       
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            IsFollowing = false;
        }
    }
}
