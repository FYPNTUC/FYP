using UnityEngine;
using System.Collections;


public class LightningFlash : MonoBehaviour
{
	public Light myLight;
	int Mtimer = 50;
	public int MFlashtimer =2;
	int counter = 0;
	int Fcounter =0;

	//Time myTime;
	// Use this for initialization
	void Start () 
	{
		myLight.enabled = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		counter ++;
		Fcounter++;
		if (counter <= Mtimer) 
		{ 
			if (Fcounter >= MFlashtimer)
			{
				myLight.enabled = !myLight.enabled;
				Fcounter = 0;
			}
		}
		counter++;

	}
}
