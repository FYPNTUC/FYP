using UnityEngine;
using System.Collections;

public class PlayerPassPlatform : MonoBehaviour 
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == ("Player"))
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<FadeInOut>().ResetLocation = GameObject.Find("ResetLocation4");
            GameObject.Find("Arrow").GetComponent<Direction>().Current = GameObject.Find("Arrow").GetComponent<Direction>().Point6;

            //GameObject.Find("PlayerFallTrigger").GetComponent<PlayerFell>().IsChecking = false;
        }
    }
}
