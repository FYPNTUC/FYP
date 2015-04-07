using UnityEngine;
using System.Collections;

public class FlyingFox : MonoBehaviour 
{
    public bool NearZip;
    GameObject Player;
    GameObject Checker;
    bool ZipIsMoving;
	// Use this for initialization
	void Start ()
    {
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
                Destroy(Checker);
                NearZip = true;
                ZipIsMoving = true;
                Player.transform.parent = gameObject.transform;
                Player.GetComponent<OVRPlayerController>().enabled = false;
                GameObject.Find("GUI").GetComponent<Renderer>().enabled = false;
            }
        }
        if (ZipIsMoving == true)
        {
            MoveTheZip();
            Debug.Log(gameObject.transform.position.z);
        }

        if (gameObject.transform.position.z < -24)
        {
            ZipIsMoving = false;
            Player.transform.parent = null;
            Player.GetComponent<OVRPlayerController>().enabled = true;
        }
    }

    void MoveTheZip()
    {
        gameObject.transform.Translate(Vector3.forward * Time.deltaTime * 35);
    }
}
