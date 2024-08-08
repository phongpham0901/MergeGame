using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    [SerializeField] private GameObject canvasMenu;

    public void ButtonMenu()
    {
        canvasMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    
    public void ButtonPlay()
    {
        Time.timeScale = 1f;
        canvasMenu.SetActive(false);
    }
    
    public void ButtonPlayAgain()
    {
        Time.timeScale = 1f;
        canvasMenu.SetActive(false);
        SceneManager.LoadScene("GamePlay");
    }
    
    public void ButtonExit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
