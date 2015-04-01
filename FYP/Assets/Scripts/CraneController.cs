using UnityEngine;
using System.Collections;

public class CraneController : MonoBehaviour
{
    GameObject Crane;
    GameObject Rope;
    //GameObject Hook;

	// Use this for initialization
	void Start () 
    {
        Crane = GameObject.Find("CraneTrolley");
        Rope = GameObject.Find("CraneRope");
        //Hook = GameObject.Find("CraneHook");
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey("e"))
        {
            Crane.transform.Translate(-Vector3.right * Time.deltaTime);
        }

        if (Input.GetKey("r"))
        {
            Crane.transform.Translate(Vector3.right * Time.deltaTime);
        }

        if (Input.GetKey("j"))
        {
           // if (Rope.transform.localScale.y < 0.0129f)
            {
                Rope.transform.localScale += new Vector3(0, 0.00010f,   0);
                //Hook.transform.localScale -= new Vector3(0, 0.00001f, 0);
            }
        }

        if (Input.GetKey("k"))
        {
            if (Rope.transform.localScale.y > 0.0129f)
            {
                Rope.transform.localScale -= new Vector3(0, 0.00010f, 0);
                //Hook.transform.localScale += new Vector3(0, 0.00001f, 0);
            }
        }

	}
}
