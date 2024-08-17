using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    
    [SerializeField] private GameObject canvasMenu;
    private GameManager gameManager;
    
    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    
    public void ButtonMenu()
    {
        canvasMenu.GetComponent<Canvas>().enabled = true;
        Time.timeScale = 0f;
        gameManager.isSetGameOver = false;
    }
    
    public void ButtonPlay()
    {
        Time.timeScale = 1f;
        canvasMenu.GetComponent<Canvas>().enabled = false;
        gameManager.isSetGameOver = true;
    }
    
    public void ButtonPlayAgain()
    {
        Time.timeScale = 1f;
        canvasMenu.GetComponent<Canvas>().enabled = false;
        SceneManager.LoadScene("GamePlay");
    }
    
    public void ButtonExit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    
    public void ButtonPlayAgainGameOver()
    {
        Time.timeScale = 1f;
        PlayerPrefs.DeleteKey("score");
        SceneManager.LoadScene("GamePlay");
    }
}
