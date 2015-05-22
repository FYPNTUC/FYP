using UnityEngine;
using System.Collections;

public class PickUpKey : MonoBehaviour 
{
    GameObject Key;
    public Material HighLight;
    Material Old;
  

	// Use this for initialization
	void Start () 
    {
        
        Key = GameObject.Find("Key");
        Old = Key.GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () 
    {
	     
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Key.GetComponent<Renderer>().material = HighLight;
        }   
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Key.GetComponent<Renderer>().material = Old;
        }
    }
}
