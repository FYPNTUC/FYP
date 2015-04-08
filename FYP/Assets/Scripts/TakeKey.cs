using UnityEngine;
using System.Collections;

public class TakeKey : MonoBehaviour 
{
    public bool CanPickUp;
    GameObject Key;
    GameObject Player;
    GameObject GUI;
	// Use this for initialization
	void Start () 
    {
        Key = GameObject.Find("Key");
        GUI = GameObject.Find("GUI");
        Player = GameObject.FindGameObjectWithTag("Player");
        
	}

    // Update is called once per frame
    void Update()
    {
        if (CanPickUp == true)
        {
            if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
            {
                //Debug.Log("key has problem");
                Destroy(Key);
                GUI.GetComponent<Renderer>().enabled = false;
                Player.GetComponent<Lift>().GotKey = true;
                //GameObject.Find("PlankCheckS").GetComponent<ShakePlank>().Screw++;
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            CanPickUp = true;
            GUI.GetComponent<Renderer>().enabled = true;

        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            CanPickUp = false;
            GUI.GetComponent<Renderer>().enabled = false;
        }
    }
}
