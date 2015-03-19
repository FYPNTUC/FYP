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
        if (GameObject.Find("First Person Controller").GetComponent<Lift>().IsTurning == true)
        {
            GameObject.Find("Lift").gameObject.transform.Rotate(Vector3.right * Time.deltaTime * SpeedOfTurning);
        }
    }
}
