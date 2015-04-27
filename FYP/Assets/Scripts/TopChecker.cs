using UnityEngine;
using System.Collections;

public class TopChecker : MonoBehaviour
{

    public GameObject MainChecker;
    public GameObject MainChecker2;
    // Use this for initialization
    void Start()
    {

        MainChecker = GameObject.Find("FirstChecker1");
        MainChecker2 = GameObject.Find("FirstChecker");
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
                GameObject.FindGameObjectWithTag("Player").GetComponent<OVRPlayerController>().enabled = true;
                GameObject.Find("PlayerModel").GetComponent<CharacterAnim>().IsTopBalancing = false;
                GameObject.Find("PlayerModel").transform.parent = GameObject.FindGameObjectWithTag("Player").transform;
                GameObject.FindGameObjectWithTag("Player").GetComponent<FadeInOut>().ResetLocation = gameObject;
            }

            if (gameObject.name == "Checker41")
            {
                MainChecker.GetComponent<TopBalance>().RotateLeft = false;
                MainChecker.GetComponent<TopBalance>().RotateRight = false;
                Destroy(MainChecker);
                GameObject.FindGameObjectWithTag("Player").GetComponent<OVRPlayerController>().enabled = true;
                GameObject.Find("PlayerModel").GetComponent<CharacterAnim>().IsTopBalancing = false;
                GameObject.FindGameObjectWithTag("Player").GetComponent<FadeInOut>().ResetLocation = gameObject;
                GameObject.Find("PlayerModel").transform.parent = GameObject.FindGameObjectWithTag("Player").transform;
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
