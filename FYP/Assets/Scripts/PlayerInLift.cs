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
        if (col.gameObject.tag=="Player") 
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Lift>().PlayerInLift = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Lift>().PlayerInLift = false;
        }
    }
}
