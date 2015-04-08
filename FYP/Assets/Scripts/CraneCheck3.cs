using UnityEngine;
using System.Collections;

public class CraneCheck3 : MonoBehaviour 
{

    GameObject Player;
    //GameObject CraneController;

    // Use this for initialization
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Player.transform.parent = gameObject.transform;
            Player.GetComponent<CraneController>().CurrentCrane = Player.GetComponent<CraneController>().Crane1;
            Player.GetComponent<CraneController>().CurrentTrolley = Player.GetComponent<CraneController>().Trolley1;
            Player.GetComponent<CraneController>().CurrentRope = Player.GetComponent<CraneController>().Rope1;

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
