using UnityEngine;
using System.Collections;

public class StartDoorScript : MonoBehaviour
{
    GameObject GUI;
    bool CanOpen;
    bool DoorIsMoving;

    // Use this for initialization
    void Start()
    {
        GUI = GameObject.Find("GUI");
        CanOpen = false;
        DoorIsMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (CanOpen == true)
        {
            if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
            {
                DoorIsMoving = true;
            }
        }

        if (DoorIsMoving == true)
        {
            MoveTheDoor();
            gameObject.GetComponent<BoxCollider>().enabled = false;
            GUI.GetComponent<Renderer>().enabled = false;
        }

        //-80
        if (gameObject.transform.eulerAngles.y <= 275 && gameObject.transform.eulerAngles.y >=270)
        {
            DoorIsMoving = false;
            CanOpen = false;
            //Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {

            GUI.GetComponent<Renderer>().enabled = true;
            CanOpen = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            GUI.GetComponent<Renderer>().enabled = false;   
            CanOpen = false;
        }
    }

    void MoveTheDoor()
    {
        gameObject.transform.Rotate(Vector3.down * Time.deltaTime * 50);
    }
}
