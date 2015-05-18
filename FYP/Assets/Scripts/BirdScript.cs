using UnityEngine;
using System.Collections;

public class BirdScript : MonoBehaviour
{
    public bool CanFly;

	// Use this for initialization
	void Start () 
    {
        CanFly = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
       // transform.LookAt(GameObject.Find("PlayerModel").transform);
        MoveTheBird();

	}

    void MoveTheBird()
    {
        if (CanFly == true)
        {
            //gameObject.GetComponent<Renderer>().enabled = true;
            gameObject.transform.Translate(Vector3.back * Time.deltaTime * 5);
        }       
    }
}
