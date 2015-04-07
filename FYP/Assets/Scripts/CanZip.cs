using UnityEngine;
using System.Collections;

public class CanZip : MonoBehaviour
{
    GameObject Handle;
    GameObject GUI;
	// Use this for initialization
	void Start () 
    { 
        GUI = GameObject.Find("GUI");
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
            GUI.GetComponent<Renderer>().enabled = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Handle.GetComponent<FlyingFox>().NearZip = false;
            GUI.GetComponent<Renderer>().enabled = false;

        }
    }
}
