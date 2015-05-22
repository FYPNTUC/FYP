using UnityEngine;
using System.Collections;

public class SlowDown : MonoBehaviour 
{
    Animator animator;


	// Use this for initialization
	void Start () 
    {
        animator = GetComponent<Animator>();
        animator.speed = 0.5f;
       //animator.["Hammering"].speed = 0.25f;
	}
	
	// Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, 103.881f,gameObject.transform.position.z);
    } // .animation
}
