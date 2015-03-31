using UnityEngine;
using System.Collections;

public class LadderScript : MonoBehaviour 
{
    GameObject Player;
    bool PlayerMove;
	// Use this for initialization
	void Start () 
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        PlayerMove = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Player.GetComponent<Lift>().PlayerNearLadder == true)
        {
            if (Input.GetKey("g") || Input.GetButtonDown("cButtonA"))
            {
                PlayerMove = true;
                Player.GetComponent<OVRPlayerController>().enabled = false;
            }
        }

        if (PlayerMove == true)
        {
            MoveThePlayer();
        }

        if()
        {
        }
	}

    void MoveThePlayer()
    {
        Player.transform.Translate(Vector3.up * Time.deltaTime);
    }
}
