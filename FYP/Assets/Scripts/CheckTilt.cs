using UnityEngine;
using System.Collections;

public class CheckTilt : MonoBehaviour
{
    public float SpeedOfTurning;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<Lift>().IsTurning == true) //&& GameObject.Find("Lift").GetComponent<Transform>().eulerAngles.x > 330 
            //&& GameObject.Find("Lift").GetComponent<Transform>().eulerAngles.x >320 )
        {
            GameObject.Find("Lift").gameObject.transform.Rotate(Vector3.left * Time.deltaTime * SpeedOfTurning);
        }

        if (GameObject.Find("Lift").GetComponent<Transform>().eulerAngles.x < 330 && GameObject.Find("Lift").GetComponent<Transform>().eulerAngles.x >320)
        {
            //GameObject.FindGameObjectWithTag("Player").transform.parent = null;
            GameObject.FindGameObjectWithTag("Player").GetComponent<Lift>().IsTurning = false;
            GameObject.FindGameObjectWithTag("Player").GetComponent<Lift>().LimitReached = true ;            
        }
    }
}   
