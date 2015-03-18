using UnityEngine;
using System.Collections;
	
public class Trampoline : MonoBehaviour 
{

	public float IncreasePerSec;

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnControllerColliderHit(ControllerColliderHit hit) 
	{

		if (hit.gameObject.name == "Trampoline") 
		{
			GameObject.FindGameObjectWithTag("Player").rigidbody.AddForce(0,100,0);
		}
	}

}
