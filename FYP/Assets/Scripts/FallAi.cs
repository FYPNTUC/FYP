using UnityEngine;
using System.Collections;

public class FallAi : MonoBehaviour
{
    GameObject FallSound;
    GameObject WorkerThank;
    GameObject WorkerGive;
    GameObject AIF;
    public bool Fall;
    bool IsFalling;
    bool IsHanging;
    bool DoOnce;
    public bool BeingHelped;
    Animator animator;
    // Use this for initialization
    void Start()
    {
        FallSound = GameObject.Find("WorkerFell");
        WorkerThank = GameObject.Find("WorkerThank");
        WorkerGive = GameObject.Find("WorkerGive");
        AIF = GameObject.FindGameObjectWithTag("AIF");
        DoOnce = false;
        animator = GetComponent<Animator>();
        Fall = false;
        IsFalling = false;
        IsHanging = false;
        BeingHelped = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Fall == true)
        {
            if (DoOnce == false)
            {
                Destroy(AIF);
                IsFalling = true;
                animator.SetBool("IsFalling", true);
                FallSound.GetComponent<AudioSource>().Play();
                DoOnce = true;
            }
        }

        if (IsFalling == true)
        {
            Falling();
        }
        if (gameObject.transform.position.y <= 48.82729)
        {
            IsFalling = false;
            IsHanging = true;
        }
        if (BeingHelped == true && IsHanging == true)
        {
            animator.SetBool("IsFalling", false);
            animator.SetBool("IsRecovering", true);
            BackUp();
            GameObject.FindGameObjectWithTag("Player").GetComponent<OVRPlayerController>().enabled = false;
            GameObject.Find("PlayerModel").GetComponent<Animation>().Play("SaveWorker");
            
        }

        if (BeingHelped == true && IsHanging == true && gameObject.transform.position.y >= 50.747)
        {

            GameObject.FindGameObjectWithTag("Player").GetComponent<OVRPlayerController>().enabled = true;
            IsHanging = false;
            BeingHelped = false;
            gameObject.transform.position = new Vector3(12.67306f, 50.65564f, 36.057f);
            GameObject.Find("HammerP").GetComponent<GotItem>().ObtainedH = true;
            WorkerThank.GetComponent<AudioSource>().Play();
            //print("pop");
        }
    }

    void Falling()
    {
        gameObject.transform.Translate(Vector3.down * Time.deltaTime * 2.5f);
    }

    void BackUp()
    {
        gameObject.transform.Translate(Vector3.up * Time.deltaTime * 1f);
    }
    //48.915
}
