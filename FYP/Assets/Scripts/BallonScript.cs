using UnityEngine;
using System.Collections;

public class BallonScript : MonoBehaviour 
{
    int Rand;

	// Use this for initialization
	void Start () 
    {
        Rand = 0;
	}
	
	// Update is called once per frame
	void Update () 
    {
     Rand =  Random.Range(1, 4);
     if (Rand == 1)
     {
         gameObject.transform.Translate(Vector3.forward * Time.deltaTime);
     }
     if (Rand == 2)
     {
         gameObject.transform.Translate(Vector3.back * Time.deltaTime);
     }

     if (Rand == 3)
     {
         gameObject.transform.Translate(Vector3.left * Time.deltaTime);
     }

     if (Rand == 4)
     {
         gameObject.transform.Translate(Vector3.right * Time.deltaTime);
     }
	}
}
