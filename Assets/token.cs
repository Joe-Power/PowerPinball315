﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token : MonoBehaviour
{
    public pointCounter Thepoints;

    private int timer = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter (Collider collision)
    {
        if (timer == 0)
        {
            Thepoints.AddPoints(1);
            Thepoints.Addmultiplier(2);
        }

        this.GetComponent<AudioSource>().Play();

    }

    // Update is called once per frame
    void FixedUpdate()
    {


    }
}