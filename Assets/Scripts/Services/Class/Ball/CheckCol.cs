using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCol : ICheckCollision
{
    public void CheckColl(GameObject gameObject, Collision2D other)
    {
        Ball ball = other.gameObject.GetComponent<Ball>();
        if (ball == null) { return; }

        if (ball.id == gameObject.GetComponent<Ball>().id)
        {
            if (ball.id < 3)
            {
                
                ChangeSize(gameObject);
                UnityEngine.Object.Destroy(other.gameObject);
            }
        }
    }

    public void ChangeSize(GameObject gameObject)
    {
        gameObject.GetComponent<Ball>().id += 1;
        Debug.Log("Spawn");
    }
}
