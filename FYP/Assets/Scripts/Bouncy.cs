using UnityEngine;
using System.Collections;

public class Bouncy : MonoBehaviour
{
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
    private int ChargeCount;

    bool done = false;
    // Use this for initialization
    void Start()
    {
        ChargeCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Physics.IgnoreLayerCollision(8, 9);

    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        CharacterController controller = GetComponent<CharacterController>();
        //check if the object is the sphere via tag
        if (hit.gameObject.tag == "Bouncy")
        {
            //allow the player to only bounce once
            if (done == false)
            {
                //make the player bounce when they first jump onto the block
                moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection *= speed;
                moveDirection.y = 15;
                moveDirection.x = 0;
                moveDirection.z = 0;
                moveDirection.y -= gravity * Time.deltaTime;
                controller.Move(moveDirection * Time.deltaTime);
                done = true;
            }

            // allows the player to charge their jump when jumping on the sphere
            if (Input.GetButton("Jump"))
            {
                ChargeCount++;
                controller.Move(moveDirection * Time.deltaTime * ChargeCount);
                Debug.Log(ChargeCount);
            }

        }
        //if the character lands on a square block resets the bounce and resets the charge
        if (hit.gameObject.tag == "Reset")
        {
            done = false;
            ChargeCount = 0;
        }

        //if (hit.gameObject.tag == "Platform")
        //{
        //    gameObject.transform.parent = hit.gameObject.transform;
        //    Debug.Log("hit");
        //}
    }
}
