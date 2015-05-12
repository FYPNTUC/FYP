using UnityEngine;
using System.Collections;

public class MoveUpBox : MonoBehaviour 
{
    GameObject PlayerModel;
    GameObject Player;
    GameObject BoxLoc;
    GameObject BoxLoc2;
    public bool CanMove;
    public bool CanMove2;
    public bool HasBox;
    public bool HasBox2;
    bool IsMoving;

	// Use this for initialization
	void Start () 
    {
        PlayerModel = GameObject.Find("PlayerModel");
        BoxLoc = GameObject.Find("BoxLoc");
        //BoxLoc = GameObject.Find("BoxLoc2");
        Player = GameObject.FindGameObjectWithTag("Player");
        CanMove = false;
        CanMove2 = false;
        HasBox = false;
        HasBox2 = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        //v1
        //if (CanMove == true)
        //{
        //    if (Input.GetKeyDown("e") || Input.GetButtonDown("cButtonA"))
        //    {
        //        Player.GetComponent<OVRPlayerController>().enabled = false;
        //        PlayerModel.GetComponent<CharacterAnim>().IsCarrying = true;
        //        PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("CarryBox");
        //        IsMoving = true;
        //        //
        //    }
        //}

        //if (IsMoving == true)
        //{
        //    MoveTheBox();
        //}
        //if (gameObject.transform.position.y >= 60.437)
        //{
        //    Player.GetComponent<OVRPlayerController>().enabled = true;
        //    IsMoving = false;
        //    gameObject.transform.parent = Player.transform;
        //}
        

        //v2

        if (CanMove == true)
        {
            if (Input.GetKeyDown("e") || Input.GetButtonDown("cButtonA"))
            {
                //Player.GetComponent<OVRPlayerController>().enabled = false;
                PlayerModel.GetComponent<CharacterAnim>().IsCarrying = true;
                gameObject.transform.position = BoxLoc.transform.position;
                gameObject.transform.rotation = BoxLoc.transform.rotation;
                gameObject.transform.parent = Player.transform;
                if (gameObject.name == "MoveAbleBox")
                {
                    HasBox = true;
                }

                else if (gameObject.name == "MoveAbleBox1")
                {
                    HasBox2 = true;
                }
                GameObject.Find("GUI").GetComponent<Renderer>().enabled = false;
                //PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("CarryBox");
                //gameObject.transform.position = new Vector3(Player.transform.position.x+1, Player.transform.position.y , Player.transform.position.z);
                //IsMoving = true;
                //
            }
        }

        else if(CanMove2 == true)
        {
            if (Input.GetKeyDown("e") || Input.GetButtonDown("cButtonA"))
            {
                if (gameObject.name == "MoveAbleBox1")
                {
                    //print("pop");
                    //Player.GetComponent<OVRPlayerController>().enabled = false;
                    PlayerModel.GetComponent<CharacterAnim>().IsCarrying = true;
                    gameObject.transform.position = BoxLoc.transform.position;
                    gameObject.transform.rotation = BoxLoc.transform.rotation;
                    
                    gameObject.transform.parent = Player.transform;
                    if (gameObject.name == "MoveAbleBox")
                    {
                        HasBox = true;
                    }

                    else if (gameObject.name == "MoveAbleBox1")
                    {
                        HasBox2 = true; 
                    }
                    CanMove2 = false;
                    GameObject.Find("GUI").GetComponent<Renderer>().enabled = false;
                    //PlayerModel.GetComponent<Animation>().GetComponent<Animation>().Play("CarryBox");
                    //gameObject.transform.position = new Vector3(Player.transform.position.x+1, Player.transform.position.y , Player.transform.position.z);
                    //IsMoving = true;
                    //
                }
            }
        }


	}
    void MoveTheBox()
    {
        //v1
        //gameObject.transform.Translate(Vector3.up * Time.deltaTime * 0.25f);
    }
}
