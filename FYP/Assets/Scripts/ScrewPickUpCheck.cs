 using UnityEngine;
using System.Collections;

public class ScrewPickUpCheck : MonoBehaviour 
{
    public bool CanPickUp;
    GameObject GUI3;
    GameObject GUI2;
    GameObject Screw;
    GameObject GUI;
	// Use this for initialization
	void Start () 
    {   
        Screw = GameObject.Find("Screw1");
        GUI = GameObject.Find("GUI");
        GUI2 = GameObject.Find("GUI2");
        GUI3 = GameObject.Find("GUI3");
    
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (CanPickUp == true)
        {
            if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
            {
                Destroy(Screw);
                GameObject.Find("PlankCheckS").GetComponent<ShakePlank>().Screw++;
                //Debug.Log("screw pick up");
                GameObject.FindGameObjectWithTag("Player").GetComponent<Lift>().NoOfScrew++;
                if (GameObject.FindGameObjectWithTag("Player").GetComponent<Lift>().NoOfScrew == 1)
                {
                    GUI2.GetComponent<Renderer>().enabled = true;
                }

                if (GameObject.FindGameObjectWithTag("Player").GetComponent<Lift>().NoOfScrew == 2)
                {
                    GUI2.GetComponent<Renderer>().enabled = false;
                    GUI3.GetComponent<Renderer>().enabled = true;
                }
                GUI.GetComponent<Renderer>().enabled = false;
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
