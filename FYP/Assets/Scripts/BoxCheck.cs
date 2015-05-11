using UnityEngine;
using System.Collections;

public class BoxCheck : MonoBehaviour 
{
    GameObject GUI;
    GameObject Box;
    GameObject Box2;
    bool Done1;
    bool Done2;

	// Use this for initialization
	void Start () 
    {
        GUI = GameObject.Find("GUI");
        Box = GameObject.Find("MoveAbleBox");
        Box2 = GameObject.Find("MoveAbleBox1");
        Done1 = false;
        Done2 = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
	    
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (Done1 == false)
            {
                if (gameObject.name == ("BoxCheck1"))
                {
                    if (GameObject.Find("MoveAbleBox").GetComponent<MoveUpBox>().HasBox == false)
                    {
                        GUI.GetComponent<Renderer>().enabled = true;
                        Box.GetComponent<MoveUpBox>().CanMove = true;
                        //print("1");
                    }
                }
            }

            if (Done2 == false)
            {
                if (gameObject.name == ("BoxCheck2"))
                {
                    if (GameObject.Find("MoveAbleBox1").GetComponent<MoveUpBox>().HasBox == false)
                    {
                        GUI.GetComponent<Renderer>().enabled = true;
                        Box2.GetComponent<MoveUpBox>().CanMove2 = true;
                        //print("2");
                    }
                }
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            GUI.GetComponent<Renderer>().enabled = false;
            Box.GetComponent<MoveUpBox>().CanMove = false;
            Box.GetComponent<MoveUpBox>().CanMove2 = false;
        }
    }
}
