using UnityEngine;
using System.Collections;

public class LastPressed : MonoBehaviour 
{
    bool IsShowing;
    float ShowTimer;

	// Use this for initialization
	void Start () 
    {
        IsShowing = false;
        ShowTimer = 5;
        //GameObject.Find("GUI").GetComponent<TextMesh>().text = "rekt";
	}
	
	// Update is called once per frame
    void Update()
    {
        if (IsShowing == true)
        {
            GameObject.Find("Last").GetComponent<MeshRenderer>().enabled = true;
            ShowTimer -= Time.deltaTime;
            if (ShowTimer <= 0)
            {
                IsShowing = false;
                GameObject.Find("Last").GetComponent<MeshRenderer>().enabled = false;
                ShowTimer = 5;
            }
        }
        if (Input.GetButtonDown("cButtonA") || Input.GetKeyDown("e"))
        {
            IsShowing = true;
            GameObject.Find("Last").GetComponent<TextMesh>().text = "Last Button pressed : A";
        }

        if (Input.GetButtonDown("cButtonB") || Input.GetKeyDown("r"))
        {
            IsShowing = true;
            GameObject.Find("Last").GetComponent<TextMesh>().text = "Last Button pressed : B";
        }
        if (Input.GetButtonDown("cButtonY") || Input.GetKeyDown("t"))
        {
            IsShowing = true;
            GameObject.Find("Last").GetComponent<TextMesh>().text = "Last Button pressed : Y";
        }

        if (Input.GetButtonDown("cButtonX") || Input.GetKeyDown("y"))
        {
            IsShowing = true;
            GameObject.Find("Last").GetComponent<TextMesh>().text = "Last Button pressed : X";
        }

        if (Input.GetButton("cLeftBumper"))
        {
            IsShowing = true;
            GameObject.Find("Last").GetComponent<TextMesh>().text = "Last Button pressed : LeftBumper";
        }

        if (Input.GetButton("cRightBumper"))
        {
            IsShowing = true;
            GameObject.Find("Last").GetComponent<TextMesh>().text = "Last Button pressed : RightBumper";
        }

        if (Input.GetAxis("cTriggers") > 0.001)
        {
            IsShowing = true;
            GameObject.Find("Last").GetComponent<TextMesh>().text = "Last Button pressed : LeftTrigger";
        }

        if (Input.GetAxis("cTriggers") < 0)
        {
            IsShowing = true;
            GameObject.Find("Last").GetComponent<TextMesh>().text = "Last Button pressed : RightTrigger";
        }


    }
}
