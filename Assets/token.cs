using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token : MonoBehaviour
{
    public Points Thepoints;

    private int timer = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

 void OnCollisionEnter(Collision collision)
        {
            if (timer == 0)
            {
                Thepoints.AddPoints(1);

            }

            this.GetComponent<AudioSource>().Play();

        }
    }
}