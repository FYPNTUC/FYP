using UnityEngine;
using System.Collections;

public class TopChecker : MonoBehaviour
{
    bool CheckPoint1;
    bool CheckPoint2;
    bool CheckPoint3;
    bool CheckPoint4;

    public GameObject MainChecker;
    // Use this for initialization
    void Start()
    {

        CheckPoint1 = false;
        CheckPoint2 = false;
        CheckPoint3 = false;
        CheckPoint4 = false;
        MainChecker = GameObject.Find("FirstChecker");
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
                MainChecker.GetComponent<TopBalance>().RotateLeft = false;
                MainChecker.GetComponent<TopBalance>().RotateRight = true;
            }

            if (gameObject.name == "Checker2")
            {
                MainChecker.GetComponent<TopBalance>().RotateLeft = true;
                MainChecker.GetComponent<TopBalance>().RotateRight = false;
            }

            if (gameObject.name == "Checker3")
            {
                MainChecker.GetComponent<TopBalance>().RotateLeft = false;
                MainChecker.GetComponent<TopBalance>().RotateRight = true;
            }

            if (gameObject.name == "Checker4")
            {
                MainChecker.GetComponent<TopBalance>().RotateLeft = false;
                MainChecker.GetComponent<TopBalance>().RotateRight = false;
                Destroy(MainChecker);
                GameObject.FindGameObjectWithTag("Player").GetComponent<OVRPlayerController>().enabled = true;
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
