using UnityEngine;
using System.Collections;

public class CraneMover : MonoBehaviour 
{
    GameObject Platform;
    GameObject Trolley;
    GameObject Rope;
    GameObject Player;
    GameObject Checker;
    GameObject Box1;
    GameObject Box2;
    GameObject Checker1;
    GameObject Checker2;

    int BoxCount;
    public bool PlatformMoving;
    bool PlatformDone;
    bool StopPls;
    bool SafeCheck;

	// Use this for initialization
	void Start () 
    {
        BoxCount = 0;
        Box1 = GameObject.Find("MoveAbleBox");
        Box2 = GameObject.Find("MoveAbleBox1");
        Checker1 = GameObject.Find("BoxCheck1");
        Checker2 = GameObject.Find("BoxCheck2");
        Platform = GameObject.Find("CraneTrigger");
        Trolley = GameObject.Find("CraneTrolleyM");
        Rope = GameObject.Find("CraneRopeM");
        Player = GameObject.FindGameObjectWithTag("Player");
        PlatformMoving = false;
        PlatformDone = false;
        Checker = GameObject.Find("CraneTrigger");
        StopPls = false;
        SafeCheck = false;

	}
	
	// Update is called once per frame
	void Update () 
    {
        if (GameObject.Find("MoveAbleBox").GetComponent<MoveUpBox>().HasBox == true)
        {
            if (Platform.GetComponent<CranePlatform>().IsOn == true)
            {
                if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
                {
                    Box1.transform.position = GameObject.Find("BoxLoc1").transform.position;
                    GameObject.Find("MoveAbleBox").GetComponent<MoveUpBox>().HasBox = false;
                    BoxCount++;
                    Box1.transform.parent = null;
                    GameObject.Find("PlayerModel").GetComponent<CharacterAnim>().IsCarrying = false;
                    GameObject.Find("MoveAbleBox").transform.parent = GameObject.Find("MovingPlank").transform;
                    Destroy(Checker1);
                    GameObject.Find("GUI").GetComponent<Renderer>().enabled = false;
                    GameObject.Find("MoveAbleBox").GetComponent<MoveUpBox>().CanMove = false;
                }
            }   
        }

        else if (GameObject.Find("MoveAbleBox1").GetComponent<MoveUpBox>().HasBox2 == true)
        {
            if (Platform.GetComponent<CranePlatform>().IsOn == true)
            {
                if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
                {

                    Box2.transform.position = GameObject.Find("BoxLoc2").transform.position;
                    GameObject.Find("MoveAbleBox1").GetComponent<MoveUpBox>().HasBox2 = false;
                    BoxCount++;
                    Box2.transform.parent = null;
                    GameObject.Find("MoveAbleBox1").transform.parent = GameObject.Find("MovingPlank").transform;
                    GameObject.Find("PlayerModel").GetComponent<CharacterAnim>().IsCarrying = false;
                    Destroy(Checker2);
                    GameObject.Find("GUI").GetComponent<Renderer>().enabled = false;
                    GameObject.Find("MoveAbleBox1").GetComponent<MoveUpBox>().CanMove2 = false;
                }
            }
        }
     
        //master switch 
        if (SafeCheck == true)
        {
            if (StopPls == false)
            {
                //check if the player is on the platform and allow the player to activate the crane
                if (Platform.GetComponent<CranePlatform>().IsOn == true)
                {
                    if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
                    {
                        PlatformMoving = true;
                        //change the reset position incase the player falls
                        Player.GetComponent<FadeInOut>().ResetLocation = GameObject.Find("ResetLocation5");
                        Checker.GetComponent<BoxCollider>().enabled = false;
                        GameObject.Find("GUI").GetComponent<Renderer>().enabled = false;
                        Platform.GetComponent<CranePlatform>().IsOn = false;
                        GameObject.Find("Arrow").GetComponent<Direction>().Current = GameObject.Find("Arrow").GetComponent<Direction>().Point7;
                        // Debug.Log("cranemover has problem");

                    }
                }

                if (Trolley.transform.position.x < -3.2)
                {
                    PlatformDone = false;
                    StopPls = true;
                }


                if (PlatformMoving == true)
                {

                    Rope.transform.Translate(Vector3.up * Time.deltaTime * 1f);
                }

                if (PlatformDone == true)
                {
                    MoveTheTrolley();
                }
            }
        }


        if (Rope.transform.position.y > 139.34) //123.34 old
        {
            PlatformMoving = false;
            PlatformDone = true;
        }

        if (BoxCount == 2)
        {
            SafeCheck = true;
        }

      
	}

    void MoveThePlatForm()
    {
        Rope.transform.Translate(Vector3.up * Time.deltaTime * 100f); //0.1
        Player.transform.position = Platform.transform.position;
       // Player.transform.position.y += 1;
    }

    void MoveTheTrolley()
    {
        Vector3 temp;
        temp = Platform.transform.position;
        temp.y += 1;
        Trolley.transform.Translate(Vector3.right * Time.deltaTime * 1f);
        Player.transform.position = temp;
        //Player.transform.position.y += 1;
    }
}
