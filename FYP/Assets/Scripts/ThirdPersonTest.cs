using UnityEngine;
using System.Collections;

public class ThirdPersonTest : MonoBehaviour 
{
    bool IsThirdPerson;
    GameObject ThirdPerson;
    Vector3 temp;

	// Use this for initialization
	void Start () 
    {
        IsThirdPerson = false;
        ThirdPerson = GameObject.Find("ThirdPerson");
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown("t"))
        {

            if (IsThirdPerson == false)
            {
                temp = GameObject.FindGameObjectWithTag("Player").transform.position;
                GameObject.FindGameObjectWithTag("Player").GetComponent<FadeInOut>().ResetLocation = ThirdPerson;
                gameObject.GetComponent<OVRPlayerController>().enabled = false;
                GameObject.Find("PlayerModel").renderer.enabled = false;
                GameObject.FindGameObjectWithTag("Player").GetComponent<FadeInOut>().ChangeLevelFade = true;
                IsThirdPerson = true;
            }

            else if (IsThirdPerson == true)
            { 
                gameObject.GetComponent<FadeInOut>().ChangeLevelFade = true;
                GameObject.Find("PlayerModel").renderer.enabled = true;
                ThirdPerson.transform.position = temp;
                gameObject.GetComponent<OVRPlayerController>().enabled = true;
                IsThirdPerson = false;       
            }
         

        }
	}
}
