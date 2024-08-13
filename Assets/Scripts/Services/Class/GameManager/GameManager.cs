using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int point;
    private int highPoint;
    [SerializeField] TextMeshProUGUI score;
    [SerializeField] private TextMeshProUGUI highScoreT;
    
    void Start()
    {
        highPoint = PlayerPrefs.GetInt("highscore");
        highScoreT.text = highPoint.ToString();
    }
    
    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + point;
        SaveScore();
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
    
}
