using UnityEngine;
using System.Collections;

public class Elevator : MonoBehaviour 
{
    GameObject Door1;
    GameObject Door2;
    GameObject Door3;
    GameObject Door4;
    Vector3 CurPos1;
    Vector3 CurPos2;
    Vector3 CurPos3;
    Vector3 CurPos4;
    bool MoveDoor;
	// Use this for initialization
	void Start () 
    {
       Door1= GameObject.Find("EDoor1");
       Door2= GameObject.Find("EDoor2");
       Door3 = GameObject.Find("EDoor3");
       Door4 = GameObject.Find("EDoor4");
       CurPos1 = Door1.transform.position;
       CurPos2 = Door2.transform.position;
       CurPos3 = Door3.transform.position;
       CurPos4 = Door4.transform.position;
        MoveDoor = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (MoveDoor == true)
        {
            if (Door1.transform.position.z < -39.6)
            {
                Door1.transform.Translate(Vector3.left * Time.deltaTime * 1);
            }

            if (Door2.transform.position.z > -41.879)
            {
                Door2.transform.Translate(Vector3.right * Time.deltaTime * 1);
            }

            if (Door3.transform.position.z < -39.6)
            {
                Door3.transform.Translate(Vector3.left * Time.deltaTime * 1);
            }

            if (Door4.transform.position.z > -41.879)
            {
                Door4.transform.Translate(Vector3.right * Time.deltaTime * 1);
            }
        }
        else if (MoveDoor == false)
        {
            //-40.59985
            if (Door1.transform.position.z >-40.5998)
            {
                Door1.transform.Translate(Vector3.right * Time.deltaTime * 1);
            }
            if (Door2.transform.position.z < -41.21985)
            {
                Door2.transform.Translate(Vector3.left * Time.deltaTime * 1);
            }
            if (Door3.transform.position.z > -40.5998)
            {
                Door3.transform.Translate(Vector3.right * Time.deltaTime * 1);
            }
            if (Door4.transform.position.z < -41.21985)
            {
                Door4.transform.Translate(Vector3.left * Time.deltaTime * 1);
            }
        }
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            MoveDoor = true;
             GameObject.Find("PlayerModel").GetComponent<CharacterAnim>().IsFlyingFox = false;
             GameObject.Find("LiftOpen").GetComponent<AudioSource>().Play();
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            MoveDoor = false;
            GameObject.Find("LiftClose").GetComponent<AudioSource>().Play();
        }
    }
    
}
