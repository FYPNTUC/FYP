using UnityEngine;
using System.Collections;

public class PlayerEnteredBuilding : MonoBehaviour 
{
    GameObject lift;
    //float Timer;
    //float ToWait;
    public bool PlayerIsInBuilding;
	// Use this for initialization
	void Start () 
    {
        PlayerIsInBuilding = false;
        lift = GameObject.Find("Lift");
        //Timer = 0;
        //ToWait = 15;
	}
	
	// Update is called once per frame
	void Update () 
    {
        //Timer = Time.deltaTime + 1;
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag ==("Player"))
        {
            Destroy(lift);
            PlayerIsInBuilding = true;
            //lift.gameObject.transform.Translate(Vector3.down * Time.deltaTime * 10);
            //GameObject.Find("Lift").gameObject.transform.Translate(Vector3.down * Time.deltaTime * 10);
            GameObject.FindGameObjectWithTag("Player").GetComponent<Lift>().StartEvent = false;
            GameObject.FindGameObjectWithTag("Player").GetComponent<FadeInOut>().ResetLocation = GameObject.Find("ResetLocation2");
        }
    }
}
