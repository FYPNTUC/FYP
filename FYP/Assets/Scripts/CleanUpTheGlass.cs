using UnityEngine;
using System.Collections;

public class CleanUpTheGlass : MonoBehaviour 
{
    float Timer;

	// Use this for initialization
	void Start () 
    {
        Timer = 10;  
	}
	
	// Update is called once per frame
	void Update () 
    {
        Timer -= Time.deltaTime ;
        if (Timer <0)
        {
            Destroy(gameObject);
        }

	}
}
