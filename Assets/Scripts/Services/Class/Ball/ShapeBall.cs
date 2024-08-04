using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class ShapeBall : IShapeBall
{
    public void SetShapeBall(GameObject gameObject, int id)
    {
        if(id == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Animals/cow");
            gameObject.GetComponent<Transform>().localScale = new Vector3(0.615f,0.615f,0.615f);
        }
        else if(id == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Animals/frog");
            gameObject.GetComponent<Transform>().localScale = new Vector3(0.88f,0.88f,0.88f);
        }
        else if(id == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Animals/giraffe");
            gameObject.GetComponent<Transform>().localScale = new Vector3(1.145f, 1.145f, 1.145f);
        }
        else if(id == 4)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Animals/monkey");
            gameObject.GetComponent<Transform>().localScale = new Vector3(1.41f, 1.41f, 1.41f);
        }
        else if(id == 5)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Animals/parrot");
            gameObject.GetComponent<Transform>().localScale = new Vector3(1.675f, 1.675f, 1.675f);
        }
        else if(id == 6)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Animals/pig");
            gameObject.GetComponent<Transform>().localScale = new Vector3(1.94f, 1.94f, 1.94f);
        }
        else if(id == 7)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Animals/snake");
            gameObject.GetComponent<Transform>().localScale = new Vector3(2.205f, 2.205f, 2.205f);
        }
        else if(id == 8)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Animals/whale");
            gameObject.GetComponent<Transform>().localScale = new Vector3(2.47f, 2.47f, 2.47f);
        }
        else if(id == 9)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Animals/chicken");
            gameObject.GetComponent<Transform>().localScale = new Vector3(2.735f, 2.735f, 2.735f);
        }
        else if(id == 10)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Animals/zebra");
            gameObject.GetComponent<Transform>().localScale = new Vector3(3,3,3);
        }
    }

    public int GetIdBall(GameObject gameObject)
    {
        return int.Parse(gameObject.tag);
    }
}
