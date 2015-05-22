using UnityEngine;
using System.Collections;

public class PlayerPassGlass : MonoBehaviour 
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
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == ("Player"))
        {
            if (gameObject.name != "PlayerPassStair")
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<FadeInOut>().ResetLocation = GameObject.Find("ResetLocation3");
                GameObject.Find("Arrow").GetComponent<Direction>().Current = GameObject.Find("Arrow").GetComponent<Direction>().Point4;
                GameObject.FindGameObjectWithTag("Player").GetComponent<Lift>().LiftIsMoving = false;
                PlayerModel.GetComponent<CharacterAnim>().CurrentFoot = PlayerModel.GetComponent<CharacterAnim>().FootStepS;
                //GameObject.Find("PlayerFallTrigger").GetComponent<PlayerFell>().IsChecking = false;
            }
            if (gameObject.name == "PlayerPassStair")
            {
                PlayerModel.GetComponent<CharacterAnim>().CurrentFoot = PlayerModel.GetComponent<CharacterAnim>().FootStepW;
                print("pop");
            }
            
        }
    }
}
