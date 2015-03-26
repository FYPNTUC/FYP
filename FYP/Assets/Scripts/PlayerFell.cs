using UnityEngine;
using System.Collections;

public class PlayerFell : MonoBehaviour 
{
    public bool PlayerFallen;
	// Use this for initialization
	void Start () 
    {
        
	}

    void Awake()
    {

    }
	// Update is called once per frame
	void Update () 
    {

	}

    void OnTriggerEnter(Collider col)
     {
         if (GameObject.Find("PlayerEnteredBuilding").GetComponent<PlayerEnteredBuilding>().PlayerIsInBuilding == true)
         {
             if (GameObject.FindGameObjectWithTag("Player"))
             {
                 GameObject.Find("OVRPlayerController").GetComponent<FadeInOut>().ChangeLevelFade = true;
             }

         }
     }
}
