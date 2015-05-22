using UnityEngine;
using System.Collections;

public class StopGangster : MonoBehaviour 
{
    GameObject CSG2;

	// Use this for initialization
	void Start () 
    {
        CSG2 = GameObject.FindGameObjectWithTag("CSG2");
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "CSG2")
        {
            CSG2.GetComponent<AIScript>().IsFollowing = false;
            CSG2.GetComponent<AIScript>().Combat = true; ;
        }
    }


    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "CSG2")
        {
         
        }
    }

}
