using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : IMove
{
    public void Movement(GameObject gameObject, float speed)
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = -speed * gameObject.transform.up;
    }
}
