using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeCircle : IShapeCircle
{
    public void SetShapeStart(GameObject gameObject)
    {
        gameObject.tag = GetShape();
        if (gameObject.tag == "1")
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
        else if(gameObject.tag == "2")
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
        }
        else if(gameObject.tag == "3")
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }
    }

    public void SetShape(GameObject gameObject)
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began && Input.GetTouch(i).position.y <= 1700)
            {
                gameObject.tag = GetShape();
                if (gameObject.tag == "1")
                {
                    gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                }
                else if(gameObject.tag == "2")
                {
                    gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
                }
                else if(gameObject.tag == "3")
                {
                    gameObject.GetComponent<SpriteRenderer>().color = Color.green;
                }
            }
        }
    }

    public string GetShape()
    {
        return UnityEngine.Random.Range(1, 4).ToString();
    }
    
}
