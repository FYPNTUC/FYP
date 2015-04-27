using UnityEngine;
using System.Collections;

public class BalancingEndCheck : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameObject.Find("PlayerModel").GetComponent<CharacterAnim>().IsBalancing = false;
            GameObject.FindGameObjectWithTag("Player").GetComponent<OVRPlayerController>().Acceleration = 0.1f;
            GameObject.FindGameObjectWithTag("Player").GetComponent<OVRPlayerController>().JumpForce = 0.3f;
        }
    }
}
