using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;
    public GameObject gameoverUI;
   
     public void EndGame()
    {
        Debug.Log("Game Over");
        gameoverUI.SetActive(true);

    }

        public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        Debug.Log("Level Won");
    }



}