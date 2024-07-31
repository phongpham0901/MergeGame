using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : ISpawnBall
{
    public void SpawnBalls(GameObject gameObject, Transform transform, GameObject circle)
    {
        GameObject ball;
        if (Input.GetKeyUp(KeyCode.C))
        {
            Debug.Log("Spawn");
            UnityEngine.Object.Instantiate(gameObject, transform.position, Quaternion.identity);
        }

        for (int i = 0; i < Input.touchCount; i++)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began && Input.GetTouch(i).position.y <= 1700)
            {
                ball = UnityEngine.Object.Instantiate(gameObject, transform.position, transform.rotation) as GameObject;
                
                ball.tag = circle.tag;

            }
        }
    }
    
}