using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGameOver : ICheckGameOver
{
    public void Check(GameObject gameObject, Collider2D other)
    {
        if (gameObject.GetComponent<Ball>().isOver)
        {
            if (other.gameObject.tag == "Finish")
            {
                Time.timeScale = 0f;
            }
        }
    }

}
