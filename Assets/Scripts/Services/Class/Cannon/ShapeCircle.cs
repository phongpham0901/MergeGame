using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeCircle : IShapeCircle
{
    public void SetShapeStart(GameObject gameObject)
    {
        gameObject.tag = GetShape();
        if(gameObject.tag == "1")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Animals/cow");
        }
        else if(gameObject.tag == "2")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Animals/frog");
        }
        else if(gameObject.tag == "3")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Animals/giraffe");
        }
        else if(gameObject.tag == "4")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Animals/monkey");
        }
        else if(gameObject.tag == "5")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Animals/parrot");
        }
        else if(gameObject.tag == "6")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Animals/pig");
        }
        else if(gameObject.tag == "7")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Animals/snake");
        }
        else if(gameObject.tag == "8")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Animals/whale");
        }
        else if(gameObject.tag == "9")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Animals/chicken");
        }
        else if(gameObject.tag == "10")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Animals/zebra");
        }
    }

    public void SetShape(GameObject gameObject)
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            if (Time.timeScale != 0)
            {
                if (Input.GetTouch(i).phase == TouchPhase.Began && Input.GetTouch(i).position.y <= 1700)
                {
                    SetShapeStart(gameObject);
                }
            }
        }
    }

    public string GetShape()
    {
        return UnityEngine.Random.Range(1, 5).ToString();
    }
    
}
