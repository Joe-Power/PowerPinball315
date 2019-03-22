using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jump : MonoBehaviour {
    Rigidbody rb;
    public int jumpspeed = 0;

    public Transform returnDestination1;
    public Transform teleportDestination;
    public Text countText;

    public Text jumpText;
    private bool istouching = true;
    private int count;

    public GameObject cameraOne;
    public GameObject cameraTwo;
    public GameObject cameraThree;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        cameraThree.SetActive(false);
        cameraOne.SetActive(true);
    }

    void FixedUpdate()
    {
        float jumpUp = Input.GetAxis("Jump");

        Vector3 hop = new Vector3(0.0f, jumpUp, 0.0f);

        rb.AddForce(hop);


if ((Input.GetKey(KeyCode.Space)) && istouching==true) 
{  
            Vector3 balljump = new Vector3(0.0f, 3.0f, 0.0f);
            this.GetComponent<AudioSource>().Play();
            rb.AddForce(balljump * jumpspeed);


        }
        istouching = false;
    }
    private void OnCollisionStay()
    {
        istouching = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();

            }
        if (other.gameObject.CompareTag("teleport"))
        {
            transform.position = teleportDestination.position;
            cameraTwo.SetActive(true);
            cameraOne.SetActive(false);
        }
        if (other.gameObject.CompareTag("return"))
        {
            transform.position = returnDestination1.position;
            cameraTwo.SetActive(false);
            cameraThree.SetActive(true); 
          
        }
        if (other.gameObject.CompareTag("regress"))
        {
            cameraTwo.SetActive(false);
            cameraThree.SetActive(false);
            cameraOne.SetActive(true);

        }
    }
    
   
        void SetCountText ()
    {
        countText.text = "Tokens: " + count.ToString ();
        jumpText.text = " ";
        if (count >= 1)
        {
            jumpText.text = "Jumpin Unlocked'";
          }
        
    }
}