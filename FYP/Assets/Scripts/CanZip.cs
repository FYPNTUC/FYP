using UnityEngine;
using System.Collections;

public class CanZip : MonoBehaviour
{
    GameObject Handle;

	// Use this for initialization
	void Start () 
    {
        Handle = GameObject.Find("FlyingFoxHandle");
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Handle.GetComponent<FlyingFox>().NearZip = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Handle.GetComponent<FlyingFox>().NearZip = false;

        }
    }
}
