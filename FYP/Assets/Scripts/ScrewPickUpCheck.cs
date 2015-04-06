using UnityEngine;
using System.Collections;

public class ScrewPickUpCheck : MonoBehaviour 
{
    public bool CanPickUp;
    GameObject Screw;
	// Use this for initialization
	void Start () 
    {   
        Screw = GameObject.Find("Screw1");
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (CanPickUp == true)
        {
            if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
            {
                Destroy(Screw);
            
            }
        }
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            CanPickUp = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            CanPickUp = false;
        }
    }
}
