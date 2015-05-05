using UnityEngine;
using System.Collections;

public class EndScript : MonoBehaviour 
{
    GameObject Player;
	// Use this for initialization
	void Start () 
    {
        Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	//Update is called once per frame
	void Update () 
    {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //Player.GetComponent<FadeInOut>().fade = true;
            Player.GetComponent<FadeInOut>().ResetLocation = GameObject.Find("ResetLocation6");
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
        }
          
    }
}
