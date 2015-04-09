using UnityEngine;
using System.Collections;

public class LadderScript : MonoBehaviour 
{
    GameObject Player;
    bool PlayerMove;
    bool PlayerMoveL;
    bool IsChecking;
    Vector3 temp;
	// Use this for initialization
	void Start () 
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        PlayerMove = false;
        PlayerMoveL = false;
        IsChecking = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Player.GetComponent<Lift>().PlayerNearLadder == true)
        {
            if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
            {
                PlayerMove = true;
                Player.GetComponent<OVRPlayerController>().enabled = false;
                temp = Player.transform.position;
                temp.y += 2;
                IsChecking = true;
                GameObject.Find("PlayerModel") .GetComponent<CharacterAnim>().
                //Debug.Log("ladder has problem");
            }
        }

        else if (Player.GetComponent<Lift>().PlayerNearLLadder == true)
        {
            if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
            {
                PlayerMoveL = true;
                Player.GetComponent<OVRPlayerController>().enabled = false;
                temp = Player.transform.position;
                temp.y += 3f;
                IsChecking = true;
                //Debug.Log("ladder has problem");
            }

        }

        if (PlayerMove == true)
        {
            MoveThePlayer();
        }

        if (PlayerMoveL == true)
        {
            MoveThePlayerL();
        }
        if (IsChecking == true)
        {
            if (Player.transform.position.y >= temp.y)
            {
                PlayerMove = false;
                PlayerMoveL = false;
                Player.GetComponent<OVRPlayerController>().enabled = true;
            }
        }
	}

    void MoveThePlayer()
    {
        Player.transform.Translate(Vector3.up * Time.deltaTime *0.2f);
        Player.transform.Translate(Vector3.forward * Time.deltaTime * 0.05f);
    }
    void MoveThePlayerL()
    {
        Player.transform.Translate(Vector3.up * Time.deltaTime *0.5f);
        Player.transform.Translate(Vector3.forward * Time.deltaTime *0.05f);
    }
}
