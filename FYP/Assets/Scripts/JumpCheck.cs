using UnityEngine;
using System.Collections;

public class JumpCheck : MonoBehaviour
{
    GameObject Display;
    // Use this for initialization
    public float ResetTime;
    void Start()
    {
        Display = GameObject.Find("JumpDisplay");
        ResetTime = 2;
    }

    // Update is called once per frame
    void Update()
    {
        ResetTime -= Time.deltaTime;
    }

    void OnTriggerEnter(Collider col)
    {
        if (ResetTime <= 0)
        {
            if (col.gameObject.tag == "Player")
            {
                GameObject.Find("PlayerModel").GetComponent<CharacterAnim>().IsLongJump = true;
                //GameObject.Find("PlayerModel").GetComponent<Animation>().GetComponent<Animation>().Play("IdleToJump");
                Display.GetComponent<Jump>().CanJump = true;
                GameObject.FindGameObjectWithTag("Player").GetComponent<OVRPlayerController>().enabled = false;
               // Display.GetComponent<Renderer>().enabled = true;
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameObject.Find("PlayerModel").GetComponent<CharacterAnim>().IsLongJump = false;
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
