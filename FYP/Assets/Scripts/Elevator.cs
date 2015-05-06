using UnityEngine;
using System.Collections;

public class Elevator : MonoBehaviour 
{
    GameObject Door1;
    GameObject Door2;
    bool MoveDoor;
	// Use this for initialization
	void Start () 
    {
       Door1= GameObject.Find("EDoor1");
       Door2= GameObject.Find("EDoor2");
        MoveDoor = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
       
        if( Door1.transform.position.z <-39.6)
        {
            Door1.transform.Translate(Vector3.left * Time.deltaTime * 1);
        }

        if (Door2.transform.position.z > -41.879)
        {
            Door2.transform.Translate(Vector3.right * Time.deltaTime * 1);
        }
       
        if (MoveDoor == true)
        {
           
        }

        else if (MoveDoor == false)
        {

        }
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            MoveDoor = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            MoveDoor = false;
        }
    }
    
}
