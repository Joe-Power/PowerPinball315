using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tokenx2 : MonoBehaviour
{
    public pointCounter Thepoints;

    private int timer = 0;

    // Start is called before the first frame update
    void Start2()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        void OnCollisionEnter(Collision collision)
        {
            if (timer == 0)
            {
                Thepoints.AddPoints(3);

            }

            this.GetComponent<AudioSource>().Play();

        }
    }
}