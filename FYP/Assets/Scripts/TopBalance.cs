using UnityEngine;
using System.Collections;

public class TopBalance : MonoBehaviour 
{
    public bool RotateLeft;
    public bool RotateRight;
    Vector3 StoredPos;
  public  bool BalanceStart;
    public GameObject Player;

   
	// Use this for initialization
	void Start () 
    {
        StoredPos = gameObject.transform.position;
        BalanceStart = false;
        Player = GameObject.FindGameObjectWithTag("Player");
        RotateRight = false;
        RotateLeft = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (BalanceStart == true)
        {
            if (Player.GetComponent<Transform>().eulerAngles.z > 20 && Player.GetComponent<Transform>().eulerAngles.z < 25)
            {
                BalanceStart = false;              
              
            }

            if (Player.GetComponent<Transform>().eulerAngles.z > 330 && Player.GetComponent<Transform>().eulerAngles.z < 340)
            {
                BalanceStart = false;               
                Player.GetComponent<OVRPlayerController>().enabled = true;
                Player.GetComponent<FadeInOut>().ChangeLevelFade = true;
                gameObject.transform.position = StoredPos;
                GameObject.Find("PlayerModel").GetComponent<CharacterAnim>().IsTopBalancing = false;
                          
            }

            GameObject.Find("PlayerModel").GetComponent<CharacterAnim>().IsTopBalancing = true;
            Player.GetComponent<OVRPlayerController>().enabled = false;

            GameObject.Find("PlayerModel").transform.parent = null;
            gameObject.transform.Translate(Vector3.forward * Time.deltaTime * 0.5f);
            Vector3 temp;
            temp = gameObject.transform.position;
            temp.y -= 0.85f;
            Player.transform.position = gameObject.transform.position;
            GameObject.Find("PlayerModel").transform.position = temp;

            if (RotateLeft == true)
            {
                Player.transform.Rotate(Vector3.forward * Time.deltaTime * 10);
                GameObject.Find("PlayerModel").transform.Rotate(Vector3.forward * Time.deltaTime * 10);
            }

            if (RotateRight == true)
            {
                Player.transform.Rotate(Vector3.back * Time.deltaTime * 10);
                GameObject.Find("PlayerModel").transform.Rotate(Vector3.back * Time.deltaTime * 10);
            }

            if (Input.GetKey("q"))// || Input.GetButtonDown("cButtonA"))
            {
                Player.transform.Rotate(Vector3.forward * Time.deltaTime * 25);
                GameObject.Find("PlayerModel").transform.Rotate(Vector3.forward * Time.deltaTime * 25);
            }

            if (Input.GetKey("e"))// || Input.GetButtonDown("cButtonA"))
            {
                Player.transform.Rotate(Vector3.back * Time.deltaTime * 25);
                GameObject.Find("PlayerModel").transform.Rotate(Vector3.back * Time.deltaTime * 25);
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
            BalanceStart = true;
            RotateLeft = true;
            Player.GetComponent<FadeInOut>().ResetLocation = GameObject.Find("ResetLocationTB");
           
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
