using UnityEngine;
using System.Collections;

public class LongLadderCheck : MonoBehaviour 
{
    GameObject Player;
	// Use this for initialization
	void Start () 
    {
        Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Player.GetComponent<Lift>().PlayerNearLLadder = true;
            Debug.Log("in");
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Player.GetComponent<Lift>().PlayerNearLLadder = false;
            Debug.Log("out");
        }
    }
}
