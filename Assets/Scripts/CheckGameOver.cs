using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGameOver : MonoBehaviour
{
    private ObjectPlayer[] objS;
    // Start is called before the first frame update
    void Start()
    {
        objS = FindObjectsOfType<ObjectPlayer>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        foreach (ObjectPlayer obj in objS)
        {
            if (obj.id == 1 || obj.id == 2 || obj.id == 3)
            {
                Time.timeScale = 0f;
            }
        }
    }
}
