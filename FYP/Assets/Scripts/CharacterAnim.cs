using UnityEngine;
using System.Collections;

public class CharacterAnim : MonoBehaviour 
{
    GameObject PlayerModel;
	// Use this for initialization
	void Start () 
    {
        PlayerModel = GameObject.Find("PlayerModel");
	}
	
	// Update is called once per frame
	void Update () 
    {
        //PlayerModel.GetComponent<Animation>().animation.Play("Idle");
        if (Input.GetKey("w") || Input.GetButtonDown("cButtonA"))
        {
            PlayerModel.GetComponent<Animation>().animation.Play("Walk");
        }

        else if (Input.GetKey("f") || Input.GetButtonDown("cButtonB"))
        {
            PlayerModel.GetComponent<Animation>().animation.Play("Jump");
        }
        else
        {
            PlayerModel.GetComponent<Animation>().animation.Play("Idle");
        }
	}
}
