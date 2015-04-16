using UnityEngine;
using System.Collections;

public class MoveUpBox : MonoBehaviour 
{
    GameObject PlayerModel;
    GameObject PlayerModel2;
    public bool CanMove;

	// Use this for initialization
	void Start () 
    {
        PlayerModel = GameObject.Find("PlayerModel");
        PlayerModel2 = GameObject.Find("PlayerModel2");
        CanMove = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (CanMove == true)
        {
            if (Input.GetKeyDown("e") || Input.GetButtonDown("cButtonA"))
            {
                PlayerModel.GetComponent<CharacterAnim>().IsCarrying = true;
                gameObject.transform.Translate(0, -100, 0);
                PlayerModel.transform.Translate(0, 100, 0);
                PlayerModel2.transform.Translate(0, 9, 0);
                PlayerModel2.animation.Play("PickUp");
                //PlayerModel2.animation.PlayQueued("MoveTheBox");
            }
        }
	}
}
