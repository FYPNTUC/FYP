using UnityEngine;
using System.Collections;

public class IPD : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {
       
        
       
       // float CurrentIpd = OVRManager.capiHmd.GetFloat(Ovr.Hmd.OVR_KEY_IPD, DEFAULT_IPD);
	}
	
	// Update is called once per frame
	void Update () 
    {
        
        float newIpd = 0.068f;
        OVRManager.capiHmd.SetFloat(Ovr.Hmd.OVR_KEY_IPD, newIpd);
        print(OVRManager.capiHmd.GetFloat(Ovr.Hmd.OVR_KEY_IPD));
	}
}
