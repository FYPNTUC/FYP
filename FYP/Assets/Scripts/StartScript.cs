using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour 
{
    Animator animator;
    GameObject Gangster1;
    GameObject Gangster2;
    GameObject Worker1;
    GameObject Worker2;
    public bool Part1Done;
    public bool Part2Done;
    public bool Part3Done;
    public float MovementSpeed;
    Vector3 Temp;
    float Timer;
     bool DoOnce;
     float FTimer;
	// Use this for initialization
	void Start () 
    {
        DoOnce = false;
        Temp = gameObject.transform.position;
        animator = GetComponent<Animator>();
        Gangster1 = GameObject.FindGameObjectWithTag("CSW1");
        Gangster2 = GameObject.FindGameObjectWithTag("CSW2");
        Worker1 = GameObject.FindGameObjectWithTag("CSG1");
        Worker2 = GameObject.FindGameObjectWithTag("CSG2");
        Part1Done = false;
        Part2Done = false;
        Part3Done = false;
        MovementSpeed = 1;
        Timer = 5;
        FTimer = 7;

	}
	
	// Update is called once per frame
    void Update()
    {

        if (GameObject.Find("Building1_KeyOfficeDoor").GetComponent<StartDoorScript>().start == true)
        {
           
            //if (DoOnce == false)
            //{
            //    //tio whack
               
            //    //GameObject.FindGameObjectWithTag("CSW1").transform.position = 
            //    // new Vector3(GameObject.FindGameObjectWithTag("CSW1").transform.position.x, -0.12f, GameObject.FindGameObjectWithTag("CSW1").transform.position.z);                     //(0, -0.877f, 0);
            //    DoOnce = true;
            //}
            //gangster1
            if (gameObject.tag == "CSG1")
            {
                if (Part1Done == false)
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<OVRPlayerController>().enabled = false;
                   // transform.LookAt(GameObject.FindGameObjectWithTag("Player").transform);
                    transform.LookAt(GameObject.Find("CSP2").transform);
                    gameObject.transform.localEulerAngles = new Vector3(0, gameObject.transform.localEulerAngles.y, gameObject.transform.localEulerAngles.z);
                    animator.SetBool("IsWalking", true);
                    transform.Translate(Vector3.forward * Time.deltaTime * MovementSpeed);
                    //transform.position = new Vector3(transform.position.x, Temp.y, transform.position.z);
                }

                else if (Part1Done == true && Part2Done == false)
                {
                    animator.SetBool("IsWalking", false);
                    transform.LookAt(GameObject.FindGameObjectWithTag("Player").transform);
                    gameObject.transform.localEulerAngles = new Vector3(0, gameObject.transform.localEulerAngles.y, gameObject.transform.localEulerAngles.z);
                    animator.SetBool("IsTalking", true);
                    Timer -= Time.deltaTime;
                    if (Timer <= 0)
                    {
                        animator.SetBool("IsTalking", false);
                        GameObject.FindGameObjectWithTag("Player").GetComponent<OVRPlayerController>().enabled = true;
                        Part2Done = true;
                    }
                }
                else if(Part2Done == true && Part3Done ==false)
                {
                    //transform.LookAt(GameObject.FindGameObjectWithTag("CSW2").transform);
                    transform.LookAt(GameObject.Find("Worker 2m").transform);
                    gameObject.transform.localEulerAngles = new Vector3(0, gameObject.transform.localEulerAngles.y, gameObject.transform.localEulerAngles.z);
                }
            }
            //gangster2
            if (gameObject.tag == "CSG2")
            { 
                if (Part1Done == false)
                {
                    transform.LookAt(GameObject.Find("CSP1").transform);
                    gameObject.transform.localEulerAngles = new Vector3(0, gameObject.transform.localEulerAngles.y, gameObject.transform.localEulerAngles.z);
                    animator.SetBool("IsWalking", true);
                    transform.Translate(Vector3.forward * Time.deltaTime * MovementSpeed);
                    //transform.position = new Vector3(transform.position.x, Temp.y, transform.position.z);
                }
                else if (Part1Done == true && Part2Done == false)
                {
                    animator.SetBool("IsWalking", false);
    
                    gameObject.transform.localEulerAngles = new Vector3(0, gameObject.transform.localEulerAngles.y, gameObject.transform.localEulerAngles.z);
                    //animator.SetBool("IsTalking", true);
                    Timer -= Time.deltaTime;
                    if (Timer <= 0)
                    {
                        Part2Done = true;         
                    }
                }

                else if (Part2Done = true && Part3Done == false)
                {

                    FTimer -= Time.deltaTime;
                    transform.LookAt(GameObject.FindGameObjectWithTag("CSW1A").transform);
                    gameObject.transform.localEulerAngles = new Vector3(0, gameObject.transform.localEulerAngles.y, gameObject.transform.localEulerAngles.z);
                    animator.SetBool("IsGuarding", true);
                    animator.SetBool("IsFight", true);
                    //  x   print(FTimer);

                    if (FTimer <= 0)
                    {
                        animator.SetBool("IsFight", false);
                        Part3Done = true;
                    }
                  
                }
            }
            //Worker1
            if (gameObject.tag == "CSW1")
            {
                transform.LookAt(GameObject.FindGameObjectWithTag("CSG2").transform);
                gameObject.transform.localEulerAngles = new Vector3(0, gameObject.transform.localEulerAngles.y, gameObject.transform.localEulerAngles.z);

                if (GameObject.FindGameObjectWithTag("CSG2").GetComponent<StartScript>().Part2Done == true)
                {
                    animator.SetBool("GettingHit", true);
                }
                if (GameObject.FindGameObjectWithTag("CSG2").GetComponent<StartScript>().Part3Done == true)
                {
                   animator.SetBool("GetRekt", true);
                   if (DoOnce == false)
                   {
                       gameObject.transform.Translate(0, 0.1056147f, 0);
                       DoOnce = true;
                   }
                }
            }
            //Worker2
            if (gameObject.tag == "CSW2")
            {
                if (GameObject.FindGameObjectWithTag("CSG2").GetComponent<StartScript>().Part2Done == true)
                {
                    
                    transform.LookAt(GameObject.FindGameObjectWithTag("CSG1").transform);
                    gameObject.transform.localEulerAngles = new Vector3(0, gameObject.transform.localEulerAngles.y, gameObject.transform.localEulerAngles.z);
                    if (Part1Done == false)
                    {
                        animator.SetBool("IsWalking", true);
                        transform.Translate(Vector3.forward * Time.deltaTime * MovementSpeed);
                    }
                    else if (Part1Done == true)
                    {
                        animator.SetBool("IsWalking", false);
                    }
                }
            }
        }
    }
    
}
