using UnityEngine;
using System.Collections;

public class Banana : MonoBehaviour 
{
    bool Moving;
    GameObject Player;
    float Timer;

	// Use this for initialization
	void Start () 
    {
        Timer = 1;
        Moving = false;
        Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Moving == true)
        {
            Player.transform.Translate(Vector3.left * Time.deltaTime * 0.5f);
        }
        if (Player.GetComponent<CharacterController>().isGrounded == false)
        {
            Timer -= Time.deltaTime;
            if (Timer <= 0)
            {
                Destroy(gameObject);
                Moving = false;
                //print("pop");
            }
        }
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            //col.transform.Translate(Vector3.left * 1f);
            Moving = true;         
        }
    }
}
