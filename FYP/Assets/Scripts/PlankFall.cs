using UnityEngine;
using System.Collections;

public class PlankFall : MonoBehaviour
{
    GameObject Plank;
    // Use this for initialization
    void Start()
    {
        Plank = GameObject.Find("ShakingPlank");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Plank.GetComponent<MeshCollider>().enabled = false;
        }
    }

    //void OnTriggerExit(Collider col)
    //{
    //    if (col.gameObject.tag == "Player")
    //    {

    //    }
    //}
}
