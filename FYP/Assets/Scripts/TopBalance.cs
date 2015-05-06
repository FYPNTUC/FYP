using UnityEngine;
using System.Collections;

public class TopBalance : MonoBehaviour
{
    public bool RotateLeft;
    public bool RotateRight;
    Vector3 StoredPos;
    public bool BalanceStart;
    public GameObject Player;


    // Use this for initialization
    void Start()
    {
        StoredPos = gameObject.transform.position;
        BalanceStart = false;
        Player = GameObject.FindGameObjectWithTag("Player");
        RotateRight = false;
        RotateLeft = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (BalanceStart == true)
        {
            //Fail Tracker
            if (GameObject.Find("PlayerModel").GetComponent<Transform>().eulerAngles.z > 20 && GameObject.Find("PlayerModel").GetComponent<Transform>().eulerAngles.z < 25)
            {
                BalanceStart = false;
                Player.GetComponent<OVRPlayerController>().enabled = true;
                Player.GetComponent<FadeInOut>().ChangeLevelFade = true;
                gameObject.transform.position = StoredPos;
                gameObject.transform.localEulerAngles = new Vector3(0, 0, 0);
                GameObject.Find("PlayerModel").GetComponent<CharacterAnim>().IsTopBalancing = false;
            }

            if (GameObject.Find("PlayerModel").GetComponent<Transform>().eulerAngles.z > 330 && GameObject.Find("PlayerModel").GetComponent<Transform>().eulerAngles.z < 340)
            {
                BalanceStart = false;
                Player.GetComponent<OVRPlayerController>().enabled = true;
                Player.GetComponent<FadeInOut>().ChangeLevelFade = true;
                gameObject.transform.position = StoredPos;
                gameObject.transform.localEulerAngles = new Vector3(0, 0, 0);
                GameObject.Find("PlayerModel").GetComponent<CharacterAnim>().IsTopBalancing = false;

            }
            //Start Tracker
            GameObject.Find("PlayerModel").GetComponent<CharacterAnim>().IsTopBalancing = true;
            Player.GetComponent<OVRPlayerController>().enabled = false;

            GameObject.Find("PlayerModel").transform.parent = null;
            gameObject.transform.Translate(Vector3.forward * Time.deltaTime * 0.5f);
            Vector3 temp;
            temp = gameObject.transform.position;
            temp.y -= 0.85f;
            Player.transform.position = gameObject.transform.position;
            Player.transform.rotation = gameObject.transform.rotation;
            GameObject.Find("PlayerModel").transform.position = temp;
            GameObject.Find("PlayerModel").transform.rotation = gameObject.transform.rotation;

            if (RotateLeft == true)
            {
                gameObject.transform.Rotate(Vector3.forward * Time.deltaTime * 10);
                //Player.transform.Rotate(Vector3.forward * Time.deltaTime * 10);
                //GameObject.Find("PlayerModel").transform.Rotate(Vector3.forward * Time.deltaTime * 10);
            }

            if (RotateRight == true)
            {
                gameObject.transform.Rotate(Vector3.back * Time.deltaTime * 10);
                //Player.transform.Rotate(Vector3.back * Time.deltaTime * 10);
                //GameObject.Find("PlayerModel").transform.Rotate(Vector3.back * Time.deltaTime * 10);
            }

            if (Input.GetKey("q") ||Input.GetButton("cButtonX"))
              // || Input.GetButtonDown("cButtonA"))
            {
                gameObject.transform.Rotate(Vector3.forward * Time.deltaTime * 25);
                //Player.transform.Rotate(Vector3.forward * Time.deltaTime * 25);
                //GameObject.Find("PlayerModel").transform.Rotate(Vector3.forward * Time.deltaTime * 25);
            }

            if (Input.GetKey("e") || Input.GetButton("cButtonB"))// || Input.GetButtonDown("cButtonA"))
            {
                gameObject.transform.Rotate(Vector3.back * Time.deltaTime * 25);
                //Player.transform.Rotate(Vector3.back * Time.deltaTime * 25);
                //GameObject.Find("PlayerModel").transform.Rotate(Vector3.back * Time.deltaTime * 25);
            }
            //int random = Random.Range(1, 10);

            //if (random >= 5)
            //{
            //    Player.transform.Rotate(Vector3.forward * Time.deltaTime *10);

            //}      
            //else if (random <= 6)
            //{
            //    Player.transform.Rotate(Vector3.back * Time.deltaTime * 10);
            //}


        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (gameObject.name == "FirstChecker")
            {
                BalanceStart = true;
                RotateLeft = true;
            }
            else if (gameObject.name == "FirstChecker1")
            {
                BalanceStart = true;
                RotateLeft = true;
                Player.GetComponent<FadeInOut>().ResetLocation = GameObject.Find("ResetLocationTB");
            }

        }
    }

    //void OnTriggerStay(Collider col)
    //{
    //    if (col.gameObject.tag == "Player")
    //    {

    //    }
    //}

    //void OnTriggerExit(Collider col)
    //{
    //    if (col.gameObject.tag == "Player")
    //    {

    //    }
    //}
}
