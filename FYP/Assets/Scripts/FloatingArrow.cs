using UnityEngine;
using System.Collections;

public class FloatingArrow : MonoBehaviour 
{
    Vector3 StartLoc;
    float Up;
    float Down;
    bool GoingUP;
    bool GoingDown;
    public bool Show;
	// Use this for initialization
	void Start () 
    {
        StartLoc = gameObject.transform.position;
        Up = StartLoc.y + 0.5f;
        Down = StartLoc.y - 0.5f;
        GoingUP = true;
        GoingDown = false;
        Show = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Show == true)
        {
            gameObject.GetComponent<Renderer>().enabled = true;
            if (GoingDown == true)
            {
                gameObject.transform.Translate(Vector3.back * Time.deltaTime);
                if (gameObject.transform.position.y < Down)
                {
                    GoingDown = false;
                    GoingUP = true;
                }
            }

            else if (GoingUP == true)
            {
                gameObject.transform.Translate(Vector3.forward * Time.deltaTime);
                {
                    if (gameObject.transform.position.y > Up)
                    {
                        GoingUP = false;
                        GoingDown = true;
                    }

                }
            }
        }

        else if (Show == false)
        {
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
}

        //if (gameObject.transform.position.y < Up)
        //{
        //    GoingUP = true;
        //    GoingDown = false;
        //    //gameObject.transform.Translate(Vector3.forward * Time.deltaTime);
        //}
        //else if (gameObject.transform.position.y > Down)
        //{
        //    GoingDown = true;
        //    GoingUP = false;
        //}

        
