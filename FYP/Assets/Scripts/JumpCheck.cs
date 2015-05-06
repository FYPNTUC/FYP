using UnityEngine;
using System.Collections;

public class JumpCheck : MonoBehaviour
{
    GameObject Display;
    // Use this for initialization
    void Start()
    {
        Display = GameObject.Find("JumpDisplay");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Display.GetComponent<Jump>().CanJump = true;
            GameObject.FindGameObjectWithTag("Player").GetComponent<OVRPlayerController>().enabled = false;
            Display.GetComponent<Renderer>().enabled = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Display.GetComponent<Jump>().CanJump = false;
            Display.GetComponent<Jump>().Jump1 = false;
            Display.GetComponent<Jump>().Jump2 = false;
            Display.GetComponent<Jump>().Jump3 = false;
            Display.GetComponent<Jump>().DoOnce = false;
            GameObject.FindGameObjectWithTag("Player").GetComponent<OVRPlayerController>().enabled = true;
            Display.GetComponent<Renderer>().enabled = false;
        }
    }
}
