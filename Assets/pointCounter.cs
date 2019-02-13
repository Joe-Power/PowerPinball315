using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    int point = 0;

    public TMPro.TextMeshPro pointtext;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        this.GetComponent<TMPro.TextMeshPro>().text = point.ToString();
    }

    public void AddPoints(int tokens)
    {
        point = point + tokens;
    }

    public void ResetPoints()
    {
        point = 0;
    }

}
