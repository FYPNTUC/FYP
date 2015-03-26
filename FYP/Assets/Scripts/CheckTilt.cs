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
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<Lift>().IsTurning == true && GameObject.Find("Lift").GetComponent<Transform>().eulerAngles.z < 30)
        {
            GameObject.Find("Lift").gameObject.transform.Rotate(Vector3.forward * Time.deltaTime * SpeedOfTurning);
        }

        if (GameObject.Find("Lift").GetComponent<Transform>().eulerAngles.z > 30)
        {
           GameObject.Find("Lift").gameObject.transform.Translate(Vector3.down * Time.deltaTime * 10);
           
        }
    }
}   
