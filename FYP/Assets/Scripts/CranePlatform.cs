using UnityEngine;
using System.Collections;

public class CranePlatform : MonoBehaviour 
{
    public bool IsOn;

	// Use this for initialization
	void Start () 
    {
        IsOn = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            IsOn = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            IsOn = false;
        }
    }
}
