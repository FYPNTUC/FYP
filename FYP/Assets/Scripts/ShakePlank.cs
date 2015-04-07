using UnityEngine;
using System.Collections;

public class ShakePlank : MonoBehaviour
{
    GameObject Plank;
    bool Shake;
    bool ShakeLeft;
    bool ShakeRight;

    // Use this for initialization
    void Start()
    {
        Plank = GameObject.Find("ShakingPlank");
        Shake = false;
        ShakeLeft = true;
        ShakeRight = false;
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Shake == true)
        {
            //if (Plank.GetComponent<Transform>().eulerAngles.x > 15) 
            //{            
            //    Plank.transform.Rotate(Vector3.back * Time.deltaTime * 150);
            //}
            //else if (Plank.GetComponent<Transform>().eulerAngles.x < 15)
            //{
            //    Plank.transform.Rotate(Vector3.forward * Time.deltaTime * 150);
            //}
            if (ShakeLeft == true)
            {
                Plank.transform.Rotate(Vector3.back * Time.deltaTime * 150);
                if (Plank.GetComponent<Transform>().eulerAngles.z > 15)
                {
                    ShakeLeft = false;
                    ShakeRight = true;
                }
            }

            if (ShakeRight == true)
            {

                Plank.transform.Rotate(Vector3.forward * Time.deltaTime * 150);
                if (Plank.GetComponent<Transform>().eulerAngles.z > 15)
                {
                    ShakeLeft = true;
                    ShakeRight = false;
                }
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Shake = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Shake = false;
        }
    }
}
