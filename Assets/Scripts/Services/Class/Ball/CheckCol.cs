using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCol : ICheckCollision
{
    
    
    public void CheckColl(GameObject gameObject, Collision2D other)
    {
        GameManager gameManager = new GameManager();
        if (GetCheckColl(gameObject, other))
        {
            ChangeSize(gameObject);
            UnityEngine.Object.Destroy(other.gameObject);
        }
    }

    public bool GetCheckColl(GameObject gameObject, Collision2D other)
    {
        Ball ball = other.gameObject.GetComponent<Ball>();
        if (ball == null) { return false; }

        if (ball.id == gameObject.GetComponent<Ball>().id)
        {
            if (ball.id < 3)
            {
                return true;
            }
        }

        return false;
    }

    public void ChangeSize(GameObject gameObject)
    {
        gameObject.GetComponent<Ball>().id += 1;
        Debug.Log("Spawn");
    }
}
