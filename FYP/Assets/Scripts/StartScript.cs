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
        Timer = 30;

	}
	
	// Update is called once per frame
    void Update()
    {
       
        if (GameObject.Find("DoorPivot").GetComponent<StartDoorScript>().start == true)
        {
           
            if (DoOnce == false)
            {
                //tio whack
                GameObject.FindGameObjectWithTag("CSW1").GetComponent<Animator>().SetBool("GetRekt", true);
                //GameObject.FindGameObjectWithTag("CSW1").transform.position = 
                new Vector3(GameObject.FindGameObjectWithTag("CSW1").transform.position.x, -0.12f, GameObject.FindGameObjectWithTag("CSW1").transform.position.z);                     //(0, -0.877f, 0);
                DoOnce = true;
            }
            //gangster1
            if (gameObject.tag == "CSG1")
            {
                if (Part1Done == false)
                {
                    transform.LookAt(GameObject.Find("CSP2").transform);
                    gameObject.transform.localEulerAngles = new Vector3(0, gameObject.transform.localEulerAngles.y, gameObject.transform.localEulerAngles.z);
                    animator.SetBool("IsWalking", true);
                    transform.Translate(Vector3.forward * Time.deltaTime * MovementSpeed);
                    transform.position = new Vector3(transform.position.x, Temp.y, transform.position.z);
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
                    transform.position = new Vector3(transform.position.x, Temp.y, transform.position.z);
                }
                else if (Part1Done == true && Part2Done == false)
                {
                    animator.SetBool("IsWalking", false);
                    transform.LookAt(GameObject.FindGameObjectWithTag("CSW1").transform);
                    gameObject.transform.localEulerAngles = new Vector3(0, gameObject.transform.localEulerAngles.y, gameObject.transform.localEulerAngles.z);
                    //animator.SetBool("IsTalking", true);
                    Timer -= Time.deltaTime;
                    if (Timer <= 0)
                    {
                        animator.SetBool("IsTalking", false);
                    }
                }
            }
            //Worker1
            if (gameObject.tag == "CSW1")
            {

            }
            //Worker2
            if (gameObject.tag == "CSW2")
            {

            }
        }
    }
    
}
