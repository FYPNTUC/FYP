using UnityEngine;
using System.Collections;

public class TalkingAi : MonoBehaviour 
{
    Animator animator;

	// Use this for initialization
	void Start() 
    {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update() 
    {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            animator.SetBool("IsTalking", true);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            animator.SetBool("IsTalking", false);
        }
    }
}
