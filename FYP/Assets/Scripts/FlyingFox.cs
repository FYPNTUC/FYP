using UnityEngine;
using System.Collections;

public class FlyingFox : MonoBehaviour 
{
    GameObject PlayerModel;
    public bool NearZip;
    GameObject Player;
    GameObject Checker;
    bool ZipIsMoving;
    Vector3 Temp;
	// Use this for initialization
	void Start ()
    {
        PlayerModel = GameObject.Find("PlayerModel");
        Player = GameObject.FindGameObjectWithTag("Player");
        Checker = GameObject.Find("FlyingFoxChecker");
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (NearZip == true)
        {
            if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
            {
                //Player.transform.parent = gameObject.transform;

                GameObject.Find("ZipLine").GetComponent<AudioSource>().Play();
                Player.GetComponent<OVRPlayerController>().enabled = false;
                GameObject.Find("GUI").GetComponent<Renderer>().enabled = false;
                Destroy(Checker);
                NearZip = true;
                ZipIsMoving = true;                            
                NearZip = false;

                PlayerModel.GetComponent<CharacterAnim>().IsFlyingFox = true;
                //Debug.Log("flyingfox has problem");
            }
        }
        if (ZipIsMoving == true)
        {
            MoveTheZip();      
        }

        if (gameObject.transform.position.z < -24)
        {
            ZipIsMoving = false;
            GameObject.Find("ZipLine").GetComponent<AudioSource>().Stop();
            //Player.transform.parent = null;
            Player.GetComponent<OVRPlayerController>().enabled = true;
            PlayerModel.GetComponent<CharacterAnim>().IsFlyingFox = false;
            PlayerModel.GetComponent<CharacterAnim>().CurrentFoot = PlayerModel.GetComponent<CharacterAnim>().FootStepG;
        }
    }

    void MoveTheZip()
    {
        gameObject.transform.Translate(Vector3.forward * Time.deltaTime * 20);
        Temp = gameObject.transform.position;
        Temp.y -= 1.32f;
        Player.transform.position = Temp;
        Player.transform.eulerAngles = new Vector3(338.3f,147.2301f,4);
        //Player.transform.eulerAngles = gameObject.transform.eulerAngles;
       
    }
}
