using UnityEngine;
using System.Collections;

public class ShakePlank : MonoBehaviour
{
    GameObject Plank;
    bool Shake;
    bool ShakeLeft;
    bool ShakeRight;
    public int Screw;
    bool PlayerNear;
    bool StopShake;
    GameObject Checker2;
    GameObject GUI;
    GameObject GUI2;
    // Use this for initialization
    void Start()
    {
        Plank = GameObject.Find("ShakingPlank");
        Shake = false;
        ShakeLeft = true;
        ShakeRight = false;
        PlayerNear = false;
        StopShake = false;
        Checker2 = GameObject.Find("PlankCheckF");
        GUI = GameObject.Find("GUI");
        GUI2 = GameObject.Find("GUI4");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (StopShake == false)
        {
            if (Shake == true)
            {
                if (ShakeLeft == true)
                {
                    Plank.transform.Rotate(Vector3.up * Time.deltaTime * 200);
                    if (Plank.GetComponent<Transform>().eulerAngles.y > 95)
                    {
                        ShakeLeft = false;
                        ShakeRight = true;
                    }
                }

                if (ShakeRight == true)
                {

                    Plank.transform.Rotate(Vector3.down * Time.deltaTime * 200);
                    if (Plank.GetComponent<Transform>().eulerAngles.y < 94)
                    {
                        ShakeLeft = true;
                        ShakeRight = false;
                    }
                }
            }
        }
         if (PlayerNear == true && Screw == 2)
        {
            if (Shake == true)
            {
                if (ShakeLeft == true)
                {
                    Plank.transform.Rotate(Vector3.up * Time.deltaTime * 200);
                    if (Plank.GetComponent<Transform>().eulerAngles.y > 95)
                    {
                        ShakeLeft = false;
                        ShakeRight = true;
                    }
                }

                if (ShakeRight == true)
                {

                    Plank.transform.Rotate(Vector3.down * Time.deltaTime * 200);
                    if (Plank.GetComponent<Transform>().eulerAngles.y < 94)
                    {
                        ShakeLeft = true;
                        ShakeRight = false;
                    }
                }
            }
            if (Input.GetKey("e") || Input.GetButtonDown("cButtonA"))
            {
                Plank.GetComponent<MeshCollider>().enabled = true;
                StopShake = true;
                Destroy(Checker2);
                GameObject.Find("GUI3").GetComponent<Renderer>().enabled = false;
                GameObject.Find("GUI2").GetComponent<Renderer>().enabled = false;
                GameObject.Find("GUI").GetComponent<Renderer>().enabled = false;
                //Debug.Log("shaker has problem");
            }
        }
    }


    void OnTriggerEnter(Collider col)
    {
        //if the player does not have 2 screw shake the plank , and when if the player keeps going ahead remove the collsion 
        if (StopShake == false)
        {
            if (col.gameObject.tag == "Player")
            {
                Shake = true;
                PlayerNear = true;
                if (Screw == 2)
                {
                    GUI.GetComponent<Renderer>().enabled = true;
                }

                if (Screw != 2)
                {
                    //GUI2.GetComponent<Renderer>().enabled = true;
                }
            }
        }
    }


    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Shake = false;
            PlayerNear = false;
            if (Screw == 2)
            {
                GUI.GetComponent<Renderer>().enabled = false;
            }
            GUI2.GetComponent<Renderer>().enabled = false;
        }
    }
}
