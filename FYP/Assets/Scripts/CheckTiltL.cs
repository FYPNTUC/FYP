using UnityEngine;
using System.Collections;

public class CheckTiltL : MonoBehaviour {

    public float SpeedOfTurning;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("First Person Controller").GetComponent<Lift>().IsTurnBack == true && GameObject.Find("Lift").GetComponent<Transform>().eulerAngles.x >=0.1)
        {
            GameObject.Find("Lift").gameObject.transform.Rotate(Vector3.up * Time.deltaTime * -SpeedOfTurning);
        }
    }
}
