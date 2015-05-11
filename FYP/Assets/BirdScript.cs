using UnityEngine;
using System.Collections;

public class BirdScript : MonoBehaviour
{

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
       // transform.LookAt(GameObject.Find("PlayerModel").transform);
        MoveTheBird();

	}

    void MoveTheBird()
    {
        gameObject.transform.Translate(Vector3.back * Time.deltaTime * 2);
        
    }
}
