using UnityEngine;
using System.Collections;

public class BalancingCheck : MonoBehaviour 
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
        if (col.gameObject.tag == "Player")
        {
            GameObject.Find("PlayerModel").GetComponent<CharacterAnim>().IsBalancing = true;
            GameObject.FindGameObjectWithTag("Player").GetComponent<OVRPlayerController>().Acceleration = 0.035f;
        }
    }

    //void OnTriggerExit(Collider col)
    //{
    //    if (col.gameObject.tag == "Player")
    //    {
          
    //    }
    //}
}
