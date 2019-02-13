using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {
    Rigidbody rb;
    public int jumpspeed = 0;
    private bool istouching = true;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float jumpUp = Input.GetAxis("Jump");

        Vector3 hop = new Vector3(0.0f, jumpUp, 0.0f);

        rb.AddForce(hop);


if ((Input.GetKey(KeyCode.Space)) && istouching==true) { 
             Vector3 balljump = new Vector3(0.0f, 3.0f, 0.0f);
             
             rb.AddForce(balljump * jumpspeed);
        }
        istouching = false;
    }
    private void OnCollisionStay()
    {
        istouching = true;
    }
}