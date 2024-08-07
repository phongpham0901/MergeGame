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
    [SerializeField] TextMeshProUGUI score;

    void Start()
    {
    }
    
    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + point;
    }

    public void Increament(int type)
    {
        point += type;
    }
    
}
