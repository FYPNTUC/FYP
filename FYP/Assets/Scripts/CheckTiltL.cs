using UnityEngine;
using System.Collections;

public class CheckTiltL : MonoBehaviour 
{

    public float SpeedOfTurning;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<Lift>().IsTurnBack == true && GameObject.Find("Lift").GetComponent<Transform>().eulerAngles.z >= 0.1)
        {
            //GameObject.Find("Lift").gameObject.transform.Rotate(Vector3.forward * Time.deltaTime * -SpeedOfTurning);
        }
    }
}
