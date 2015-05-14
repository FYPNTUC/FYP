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
            if (gameObject.name == "End")
            {
                Player.GetComponent<FadeInOut>().ResetLocation = GameObject.Find("ResetLocation11");
            }

            if (gameObject.name == "End2")
            {
                Player.GetComponent<FadeInOut>().ResetLocation = GameObject.Find("ResetLocation12");
            }

            if (gameObject.name == "End3")
            {
                Player.GetComponent<FadeInOut>().ResetLocation = GameObject.Find("ResetLocation13");
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
        }
          
    }
}
