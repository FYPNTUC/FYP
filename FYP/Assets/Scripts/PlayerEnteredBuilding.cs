using UnityEngine;
using System.Collections;

public class PlayerEnteredBuilding : MonoBehaviour 
{
    GameObject lift;
    public bool PlayerIsInBuilding;
	// Use this for initialization
	void Start () 
    {
        PlayerIsInBuilding = false;
        lift = GameObject.Find("Lift");
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag ==("Player"))
        {
            PlayerIsInBuilding = true;
            //Destroy(lift);
            GameObject.FindGameObjectWithTag("Player").GetComponent<Lift>().StartEvent = false;
        }
    }
}
