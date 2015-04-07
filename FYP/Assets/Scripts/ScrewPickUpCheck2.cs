using UnityEngine;
using System.Collections;

public class ScrewPickUpCheck2 : MonoBehaviour 
{
    public bool CanPickUp;
    GameObject Screw;
    GameObject GUI;
    // Use this for initialization
    void Start()
    {
        Screw = GameObject.Find("Screw2");
        GUI = GameObject.Find("GUI");
    }

    // Update is called once per frame
    void Update()
    {
        if (CanPickUp == true)
        {
            if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
            {
                Destroy(Screw);

            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            CanPickUp = true;
            GUI.GetComponent<Renderer>().enabled = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            CanPickUp = false;
            GUI.GetComponent<Renderer>().enabled = false;
        }
    }
}
