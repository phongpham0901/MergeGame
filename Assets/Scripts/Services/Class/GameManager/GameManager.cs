using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int point;
    private int highPoint;
    [SerializeField] private TextMeshProUGUI score;
    [SerializeField] private TextMeshProUGUI highScoreT;
    [SerializeField] public bool isSetGameOver;

    private void Awake()
    {
        isSetGameOver = true;
    }

    void Start()
    {
        highPoint = PlayerPrefs.GetInt("highscore");
        highScoreT.text = highPoint.ToString();
    }
    
    // Update is called once per frame
    void Update()
    {
        SetTextScore();
        SaveScore();
        GameOver();
        //PlayerPrefs.DeleteKey("highscore");
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.DeleteKey("score");

        Debug.Log("Game is quitting, score key has been deleted.");
    }
    
    private void SetTextScore()
    {
        if (SceneManager.GetActiveScene().name == "GamePlay")
        {
            score.text = "Score: " + point;
        }
        else
        {
            score.text = PlayerPrefs.GetInt("score").ToString();
        }
    }

    public void Increament(int type)
    {
        point += type;
    }

    public void SaveScore()
    {
        if (point > highPoint)
        {
            PlayerPrefs.SetInt("highscore", point);
        }
    }

    public void GameOver()
    {
        if (Time.timeScale == 0f && isSetGameOver && SceneManager.GetActiveScene().name == "GamePlay")
        {
            PlayerPrefs.SetInt("score", point);
            SceneManager.LoadScene("GameOver");
        }
    }
    
}
