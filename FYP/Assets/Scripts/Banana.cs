using UnityEngine;
using System.Collections;

public class Banana : MonoBehaviour 
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
        if (col.tag == "Player")
        {
            col.transform.Translate(Vector3.left * 0.5f);
        }
    }
}
