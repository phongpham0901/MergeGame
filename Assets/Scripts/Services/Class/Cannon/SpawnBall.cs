using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : ISpawnBall
{
    public void SpawnBalls(GameObject gameObject, Transform transform)
    {
        if (Input.GetKeyUp(KeyCode.C))
        {
            Debug.Log("Spawn");
            UnityEngine.Object.Instantiate(gameObject, transform.position, Quaternion.identity);
        }

        for (int i = 0; i < Input.touchCount; i++)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                UnityEngine.Object.Instantiate(gameObject, transform.position, transform.rotation);
            }
        }
        
    }
}
