using UnityEngine;
using System.Collections;

public class PlayerPassGlass : MonoBehaviour 
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
        if (col.gameObject.tag == ("Player"))
        {  
            GameObject.FindGameObjectWithTag("Player").GetComponent<FadeInOut>().ResetLocation = GameObject.Find("ResetLocation3");
            GameObject.Find("PlayerFallTrigger").GetComponent<PlayerFell>().IsChecking = false;
        }
    }
}
