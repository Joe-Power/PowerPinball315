using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump2 : MonoBehaviour
{
    //these variables we want accessible in the unity editor
    public float speed = 3.0f;
    public float maxJumpVel = 4f;
    public float jumpAccel = 10f;
    public float gravity = 25f;

    private bool isGrounded = true;

    private Vector3 moveDirection = Vector3.zero;


    // Start is called before the first frame update


    void Update()
    {


        if (Input.GetButton("Jump"))
        {
            moveDirection.y = jumpAccel;
        }
    }
}
    
