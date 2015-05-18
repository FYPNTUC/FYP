using UnityEngine;
using System.Collections;

public class ThirdPerson : MonoBehaviour
{
    GameObject PlayerModel;
    bool IsThirdPerson;
    Vector3 StartPos;
    bool IsMoving;
    float Timer;
    // Use this for initialization
    void Start()
    {
       PlayerModel= GameObject.Find("PlayerModel");
      
        IsMoving = false;
        Timer = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsThirdPerson == false)
        {
            if (Input.GetKeyDown("t") || Input.GetButtonDown("cButtonY"))
            {
                StartPos = gameObject.transform.position;
                gameObject.GetComponent<OVRPlayerController>().enabled = false;
              
                PlayerModel.transform.parent = null;
                IsThirdPerson = true;
                IsMoving = true;
                Timer = 2;
            }
        }
         
        else if (IsThirdPerson == true)
        {
            if (Input.GetKeyDown("t") ||Input.GetButtonDown("cButtonY"))
            {
                IsThirdPerson = false;
                IsMoving = false;
                Timer = 2;
                gameObject.GetComponent<OVRPlayerController>().enabled = true;
                gameObject.transform.position = StartPos;
                PlayerModel.transform.parent = gameObject.transform;
            }
        }

        if (IsMoving == true)
        {
            MoveTheChar();
        }
    }

    void MoveTheChar()
    {
        Timer -= Time.deltaTime;
        if (Timer >= 0)
        {
            gameObject.transform.Translate(Vector3.back * Time.deltaTime);
            gameObject.transform.Translate(Vector3.up * Time.deltaTime);
        }
    }
}
