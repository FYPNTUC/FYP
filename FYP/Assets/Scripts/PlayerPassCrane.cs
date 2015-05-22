using UnityEngine;
using System.Collections;

public class PlayerPassCrane : MonoBehaviour 
{
    GameObject PlayerModel;
    GameObject GangsterPat;
    // Use this for initialization
    void Start()
    {
        GangsterPat = GameObject.Find("GangsterPat");
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
            GameObject.Find("DoorSlam").GetComponent<AudioSource>().Play();
            GameObject.FindGameObjectWithTag("Player").GetComponent<FadeInOut>().ResetLocation = GameObject.Find("ResetLocation5");
            GangsterPat.GetComponent<GangsterPatrol>().EventStart = true;
            PlayerModel.GetComponent<CharacterAnim>().CurrentFoot = PlayerModel.GetComponent<CharacterAnim>().FootStepW;
            //GameObject.Find("PlayerFallTrigger").GetComponent<PlayerFell>().IsChecking = false;
        }
       
    }
}
