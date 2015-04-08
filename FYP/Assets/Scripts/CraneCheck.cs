using UnityEngine;
using System.Collections;

public class CraneCheck : MonoBehaviour 
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
            Player.transform.parent = gameObject.transform;
            Player.GetComponent<CraneController>().CanBeMoved = true;
            Player.GetComponent<CraneController>().CurrentCrane = Player.GetComponent<CraneController>().Crane3;
            Player.GetComponent<CraneController>().CurrentTrolley = Player.GetComponent<CraneController>().Trolley3;
            Player.GetComponent<CraneController>().CurrentRope = Player.GetComponent<CraneController>().Rope3;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Player.transform.parent = null;
        }
    }
}
