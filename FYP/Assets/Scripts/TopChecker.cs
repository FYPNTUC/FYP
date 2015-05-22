using UnityEngine;
using System.Collections;

public class TopChecker : MonoBehaviour
{

    public GameObject MainChecker;
    public GameObject MainChecker2;
    GameObject ModelRes;
    GameObject Player;
    GameObject PlayerModel;
    // Use this for initialization
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        PlayerModel = GameObject.Find("PlayerModel");
        MainChecker = GameObject.Find("FirstChecker1");
        MainChecker2 = GameObject.Find("FirstChecker");
        ModelRes = GameObject.Find("ModelRes");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (gameObject.name == "Checker1")
            {
                MainChecker2.GetComponent<TopBalance>().RotateLeft = false;
                MainChecker2.GetComponent<TopBalance>().RotateRight = true;
                MainChecker.GetComponent<TopBalance>().RotateLeft = false;
                MainChecker.GetComponent<TopBalance>().RotateRight = true;
            }

            if (gameObject.name == "Checker2")
            {
                MainChecker2.GetComponent<TopBalance>().RotateLeft = true;
                MainChecker2.GetComponent<TopBalance>().RotateRight = false;
                MainChecker.GetComponent<TopBalance>().RotateLeft = true;
                MainChecker.GetComponent<TopBalance>().RotateRight = false;           
            }

            if (gameObject.name == "Checker3")
            {

                MainChecker2.GetComponent<TopBalance>().RotateLeft = false;
                MainChecker2.GetComponent<TopBalance>().RotateRight = true;
                MainChecker.GetComponent<TopBalance>().RotateLeft = false;
                MainChecker.GetComponent<TopBalance>().RotateRight = true;
            }

            if (gameObject.name == "Checker4")
            {
                MainChecker2.GetComponent<TopBalance>().RotateLeft = false;
                MainChecker2.GetComponent<TopBalance>().RotateRight = false;
                Destroy(MainChecker2);
                Player.GetComponent<OVRPlayerController>().enabled = true;
                PlayerModel.GetComponent<CharacterAnim>().IsTopBalancing = false;
                PlayerModel.transform.parent = Player.transform;
                PlayerModel.transform.rotation = Player.transform.rotation;
                PlayerModel.transform.position = ModelRes.transform.position;
                Player.GetComponent<FadeInOut>().ResetLocation = gameObject;
            }

            if (gameObject.name == "Checker41")
            {
                MainChecker.GetComponent<TopBalance>().RotateLeft = false;
                MainChecker.GetComponent<TopBalance>().RotateRight = false;
                Destroy(MainChecker);
                Player.GetComponent<OVRPlayerController>().enabled = true;
                PlayerModel.GetComponent<CharacterAnim>().IsTopBalancing = false;
                Player.GetComponent<FadeInOut>().ResetLocation = gameObject;
                PlayerModel.transform.rotation = Player.transform.rotation;
                PlayerModel.transform.parent = Player.transform;
                PlayerModel.transform.position = ModelRes.transform.position;
            }
        }
    }



    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {

        }
    }
}
