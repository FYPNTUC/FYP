using UnityEngine;
using System.Collections;

public class PlayerInLift : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "First Person Controller")
        {
            GameObject.Find("First Person Controller").GetComponent<Lift>().PlayerInLift = true;
            Debug.Log("in");
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "First Person Controller")
        {
            GameObject.Find("First Person Controller").GetComponent<Lift>().PlayerInLift = false;
            Debug.Log("out");
        }
    }
}
