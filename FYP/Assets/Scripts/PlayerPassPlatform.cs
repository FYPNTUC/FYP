using UnityEngine;
using System.Collections;

public class PlayerPassPlatform : MonoBehaviour 
{
    GameObject PlayerModel;
    // Use this for initialization
    void Start()
    {
        PlayerModel = GameObject.Find("PlayerModel");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == ("Player"))
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<FadeInOut>().ResetLocation = GameObject.Find("ResetLocation4");
            GameObject.Find("Arrow").GetComponent<Direction>().Current = GameObject.Find("Arrow").GetComponent<Direction>().Point6;
            PlayerModel.GetComponent<CharacterAnim>().CurrentFoot = PlayerModel.GetComponent<CharacterAnim>().FootStepG;

            //GameObject.Find("PlayerFallTrigger").GetComponent<PlayerFell>().IsChecking = false;
        }
    }
}
