using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public GameObject objSpawn;
    private ObjectPlayer[] obj;
    public int point = 0;
    void Start()
    {
        obj = FindObjectsOfType<ObjectPlayer>();
    }
    
    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void Increa(int type)
    {
        point+=type;
    }
    
}
