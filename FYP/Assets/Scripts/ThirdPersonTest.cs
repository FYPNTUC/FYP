using UnityEngine;
using System.Collections;

public class ThirdPersonTest : MonoBehaviour 
{
    bool IsThirdPerson;
    GameObject ThirdPerson;
    Vector3 temp;
    bool CharIsMovingUp;
    bool CharIsMovingDown;
    bool CharIsMovingLeft;
    bool CharIsMovingRight;
    bool CharIsMovingForward;
    bool CharIsMovingBackward;
    Vector3 Temp;

	// Use this for initialization
	void Start () 
    {
        IsThirdPerson = false;
        ThirdPerson = GameObject.Find("ThirdPerson");
        CharIsMovingUp = false;
        CharIsMovingDown = false;
        CharIsMovingLeft = false;
        CharIsMovingRight = false;
        CharIsMovingForward = false;
        CharIsMovingBackward = false;


	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown("t"))
        {

            if (IsThirdPerson == false)
            {
                temp = GameObject.FindGameObjectWithTag("Player").transform.position;
                gameObject.GetComponent<FadeInOut>().ResetLocation = ThirdPerson;
                gameObject.GetComponent<OVRPlayerController>().enabled = false;
                //GameObject.Find("PlayerModel").SetActive(false);
                GameObject.Find("PlayerModel").transform.Translate(100, 100, 100);
                GameObject.FindGameObjectWithTag("Player").GetComponent<FadeInOut>().ChangeLevelFade = true;
                IsThirdPerson = true;
            }

            else if (IsThirdPerson == true)
            { 
                gameObject.GetComponent<FadeInOut>().ChangeLevelFade = true;
                //GameObject.Find("PlayerModel").SetActive(true);
                GameObject.Find("PlayerModel").transform.Translate(-100, -100, -100);
                ThirdPerson.transform.position = temp;
                gameObject.GetComponent<OVRPlayerController>().enabled = true;
                IsThirdPerson = false;

               
            }
           
        }
        if (IsThirdPerson == true)
        {
            if (Input.GetKeyDown("y"))
            {
                temp = GameObject.FindGameObjectWithTag("Player").transform.position;
                temp.z -= 2f;
                CharIsMovingBackward = true;
            }
        }

        if (CharIsMovingBackward == true)
        {
            MoveTheCharBack();
            if (GameObject.FindGameObjectWithTag("Player").transform.position.z < temp.z)
            {
                CharIsMovingBackward = false;
                CharIsMovingRight = true;
                temp = GameObject.FindGameObjectWithTag("Player").transform.position;
                temp.x += 4;
            }
        }

        if (CharIsMovingRight == true)
        {
            MoveTheCharRight();
            if (GameObject.FindGameObjectWithTag("Player").transform.position.x > temp.x)
            {
                CharIsMovingRight = false;
                CharIsMovingForward = true;
                temp = GameObject.FindGameObjectWithTag("Player").transform.position;
                temp.z += 8;
            }
        }

        if (CharIsMovingForward == true)
        {
            MoveTheCharForward();
            if (GameObject.FindGameObjectWithTag("Player").transform.position.z > temp.z)
            {
                CharIsMovingForward = false;
            }
        }
	}

    void MoveTheCharBack()
    {
        GameObject.FindGameObjectWithTag("Player").transform.Translate(Vector3.back * Time.deltaTime);
    }

    void MoveTheCharForward()
    {
        GameObject.FindGameObjectWithTag("Player").transform.Translate(Vector3.forward * Time.deltaTime);
    }
    void MoveTheCharLeft()
    {
        GameObject.FindGameObjectWithTag("Player").transform.Translate(Vector3.left * Time.deltaTime);
    }
    void MoveTheCharRight()
    {
        GameObject.FindGameObjectWithTag("Player").transform.Translate(Vector3.right * Time.deltaTime);
    }

    void MoveTheCharUp()
    {
        GameObject.FindGameObjectWithTag("Player").transform.Translate(Vector3.up * Time.deltaTime);
    }

    void MoveTheCharDown()
    {
        GameObject.FindGameObjectWithTag("Player").transform.Translate(Vector3.down * Time.deltaTime);
    }
}
