using UnityEngine;
using System.Collections;

public class CranePlatform : MonoBehaviour 
{
    GameObject GUI;
    public bool IsOn;

	// Use this for initialization
	void Start () 
    {
        IsOn = false;
        GUI = GameObject.Find("GUI");
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (GameObject.Find("MoveAbleBox").GetComponent<MoveUpBox>().HasBox == true || GameObject.Find("MoveAbleBox1").GetComponent<MoveUpBox>().HasBox2 == true)
            {
                IsOn = true;
                GUI.GetComponent<Renderer>().enabled = true;
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            IsOn = false;
            GUI.GetComponent<Renderer>().enabled = false;
        }
    }
}
