using UnityEngine;
using System.Collections;

public class GotItem : MonoBehaviour 
{
    public bool ObtainedH;
    float Timer;
	// Use this for initialization
	void Start () 
    {
        ObtainedH = false;
        Timer = 5;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (ObtainedH == true)
        {
            Timer -= Time.deltaTime;
            if (Timer >= 0)
            {
                gameObject.transform.Rotate(Vector3.forward * Time.deltaTime * 60);
                //ObtainedH = false;
               
            }
            if (Timer <= 0)
            {
                gameObject.GetComponent<Renderer>().enabled = false;
            }
        }
	}
}
