using UnityEngine;
using System.Collections;

public class CraneMover : MonoBehaviour 
{
    GameObject GUI;
    GameObject PlayerModel;
    GameObject Platform;
    GameObject Trolley;
    GameObject Rope;
    GameObject Player;
    GameObject Checker;
    GameObject Box1;
    GameObject Box2;
    GameObject Checker1;
    GameObject Checker2;
    GameObject MoveAbleBox1;
    GameObject MoveAbleBox2;
    GameObject MovingPlank;
    GameObject BoxLoc1;
    GameObject BoxLoc2;

    int BoxCount;
    public bool PlatformMoving;
    bool PlatformDone;
    bool StopPls;
    bool SafeCheck;

	// Use this for initialization
	void Start () 
    {
        GUI = GameObject.Find("GUI");
        BoxLoc1 = GameObject.Find("BoxLoc1");
        BoxLoc2 = GameObject.Find("BoxLoc3");
        BoxCount = 0;
        MoveAbleBox1 = GameObject.Find("MoveAbleBox");
        MoveAbleBox2 = GameObject.Find("MoveAbleBox1");
        PlayerModel = GameObject.Find("PlayerModel");
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
        MovingPlank = GameObject.Find("MovingPlank");

	}
	
	// Update is called once per frame
	void Update () 
    {
        if (MoveAbleBox1.GetComponent<MoveUpBox>().HasBox == true)
        {
            if (Platform.GetComponent<CranePlatform>().IsOn == true)
            {
                if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
                {
                    Box1.transform.position = BoxLoc1.transform.position;
                    MoveAbleBox1.GetComponent<MoveUpBox>().HasBox = false;
                    BoxCount++;
                    Box1.transform.parent = null;
                    PlayerModel.GetComponent<CharacterAnim>().IsCarrying = false;
                    MoveAbleBox1.transform.parent = MovingPlank.transform;
                    Destroy(Checker1);
                    GUI.GetComponent<Renderer>().enabled = false;
                    MoveAbleBox1.GetComponent<MoveUpBox>().CanMove = false;
                    PlayerModel.GetComponent<CharacterAnim>().IsBox1 = false;
                    PlayerModel.GetComponent<CharacterAnim>().DownBox = false;
                    PlayerModel.GetComponent<CharacterAnim>().IsUp = false;
                    PlayerModel.GetComponent<CharacterAnim>().RaisingBox = false;
                }
            }
        }

        if (MoveAbleBox2.GetComponent<MoveUpBox>().HasBox2 == true)
        {
            if (Platform.GetComponent<CranePlatform>().IsOn == true)
            {
                if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
                {

                    Box2.transform.position = BoxLoc2.transform.position;
                    MoveAbleBox2.GetComponent<MoveUpBox>().HasBox2 = false;
                    BoxCount++;
                    Box2.transform.parent = null;
                    MoveAbleBox2.transform.parent = MovingPlank.transform;
                    PlayerModel.GetComponent<CharacterAnim>().IsCarrying = false;
                    Destroy(Checker2);
                    GUI.GetComponent<Renderer>().enabled = false;
                    MoveAbleBox2.GetComponent<MoveUpBox>().CanMove2 = false;
                    PlayerModel.GetComponent<CharacterAnim>().IsBox2 = false;
                    PlayerModel.GetComponent<CharacterAnim>().DownBox = false;
                    PlayerModel.GetComponent<CharacterAnim>().IsUp = false;
                    PlayerModel.GetComponent<CharacterAnim>().RaisingBox = false;
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
