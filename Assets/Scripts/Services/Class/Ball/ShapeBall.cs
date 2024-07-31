using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeBall : IShapeBall
{
    public void SetShapeBall(GameObject gameObject, int id)
    {
        if (id == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            gameObject.GetComponent<Transform>().localScale = new Vector3(0.5f,0.5f,1);
        }
        else if(id == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
            gameObject.GetComponent<Transform>().localScale = new Vector3(0.75f,0.75f,1);
        }
        else if(id == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
            gameObject.GetComponent<Transform>().localScale = new Vector3(1,1,1);
        }
    }

    public int GetIdBall(GameObject gameObject)
    {
        return int.Parse(gameObject.tag);
    }
}