using UnityEngine;
using System.Collections;

public class BreakController : MonoBehaviour 
{
    public GameObject ShatteredGlass;
    public GameObject ShatteredScaff;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == ("BreakableG"))
        {
            Vector3 temp;
            temp = hit.transform.position;
            temp.y -= 1;
            Destroy(hit.gameObject);
            Instantiate(ShatteredGlass, temp, Quaternion.identity);
            GameObject.Find("Glass").transform.position = transform.position;
            GameObject.Find("Glass").GetComponent<AudioSource>().Play();//    .enabled = true;
        }
        if (hit.gameObject.tag == ("Breakable"))
        {
            Vector3 temp;
            temp = hit.transform.position;
            Destroy(hit.gameObject);
            Instantiate(ShatteredScaff, temp, Quaternion.identity);
        }
    }
}
