using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour
{
    private Vector3 initialposition;
    public GameObject theball;

    public GameObject cameraOne;
    public GameObject cameraTwo;
    // Start is called before the first frame update
    void Start()
    {
        initialposition = theball.transform.position;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == theball)
        {
            Debug.Log("game over");
        
        }
    }
    }
