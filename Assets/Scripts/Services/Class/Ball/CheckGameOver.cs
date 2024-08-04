using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGameOver : ICheckGameOver
{
    public void SetTime(Collider2D other, bool isInside, float timeSpent)
    {
        if (other.CompareTag("Finish"))
        {
            isInside = false;
            timeSpent = 0f;
        }
    }

    public void Check(Collider2D other, GameObject gameObject)
    {
        if (other.CompareTag("Finish"))
        {
            if (gameObject.GetComponent<Ball>().isInside)
            {
                gameObject.GetComponent<Ball>().timeSpent += Time.deltaTime; // Tăng thời gian đối tượng ở trong vùng trigger

                if (gameObject.GetComponent<Ball>().timeSpent >= gameObject.GetComponent<Ball>().triggerDuration)
                {
                    // Thực hiện hành động khi đối tượng ở trong vùng trigger quá lâu
                    Debug.Log("Đối tượng đã ở trong vùng trigger quá 5 giây!");
                    Time.timeScale = 0f;
                }
            }
        }
    }

}
