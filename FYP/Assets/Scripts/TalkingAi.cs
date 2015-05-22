using UnityEngine;
using System.Collections;

public class TalkingAi : MonoBehaviour 
{
    Animator animator;
    GameObject WorkerBox;
    GameObject WorkerCrane;
    GameObject Plank;
    bool DoOnce;

	// Use this for initialization
	void Start() 
    {
        DoOnce = false;
        WorkerCrane = GameObject.Find("WorkerCrane");
        animator = GetComponent<Animator>();
        WorkerBox = GameObject.Find("WorkerBox");
        Plank = GameObject.Find("WorkerPlank");
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
            if(gameObject.name == ("BoxWorker"))
            {
                if (DoOnce == false)
                {
                    WorkerBox.GetComponent<AudioSource>().Play();
                    DoOnce = true;
                }
            }

            if (gameObject.name == ("ShakeWorker"))
            {
                if (DoOnce == false)
                {
                    Plank.GetComponent<AudioSource>().Play();
                      DoOnce = true;
                }
            }
            if(gameObject.name == ("CraneWorker"))
            {
                if (DoOnce == false)
                {
                    WorkerCrane.GetComponent<AudioSource>().Play();
                    DoOnce = true;
                }
            }
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
