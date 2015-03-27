using UnityEngine;
using System.Collections;

public class PlayerFell : MonoBehaviour 
{
    public bool IsChecking;
    public bool PlayerFallen;
	// Use this for initialization
	void Start () 
    {
        IsChecking = true;
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
        if (IsChecking == true)
        {
            if (GameObject.FindGameObjectWithTag("Player").GetComponent<Lift>().LiftIsMoving == false)
            {
                if (col.gameObject.tag == ("Player"))
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<FadeInOut>().ChangeLevelFade = true;
                }

            }
        }
    }
}
