using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointCounter : MonoBehaviour
{
    int point = 0;
    int multiplier = 1;
    public TMPro.TextMeshPro pointtext;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        this.GetComponent<TMPro.TextMeshPro>().text = point.ToString();
        pointtext.text = "x" + multiplier.ToString();
    }

    public void AddPoints(int points)
    {
        point = point + points * multiplier;
    }

    public void Addmultiplier(int multiplierpoints)
    {
        multiplier = multiplier + multiplierpoints;
    }




   public void ResetPoints()
    {
      //  point = 0;
    }

}
