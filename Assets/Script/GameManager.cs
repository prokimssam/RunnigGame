using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject winPanelObj;
    public GameObject losePanelObj;

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void Win()
    {
        winPanelObj.SetActive(true);
        Debug.Log("Win!");
        Time.timeScale = 0;
    }
    
    public void Lose()
    {
        losePanelObj.SetActive(true);
        Debug.Log("Lose!");
        Time.timeScale = 0;
    }
}
