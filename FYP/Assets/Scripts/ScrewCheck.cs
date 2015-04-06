using UnityEngine;
using System.Collections;

public class ScrewCheck : MonoBehaviour
{
    GameObject Screw;
    public Material HighLight;
    Material Old;
	// Use this for initialization
	void Start () 
    {
        Screw = GameObject.Find("Screw1");
       Old = Screw.GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Screw.GetComponent<Renderer>().material = HighLight;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Screw.GetComponent<Renderer>().material = Old;
        }
    }

}
