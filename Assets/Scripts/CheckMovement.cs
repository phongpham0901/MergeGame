using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMovement : ICheckMovement
{
    public void CheckMove(GameObject gameObject)
    {
        //Not move
        if (gameObject.transform.position.y <= 3 && gameObject.GetComponent<Rigidbody2D>().velocity.magnitude <= 0)
        {
            CheckCollision checkCollisionComponent = gameObject.GetComponent<CheckCollision>();
            if (checkCollisionComponent == null)
            {
                return;
            }
            else
            {
                checkCollisionComponent.enabled = false;
            }
        }
        
        //Move
        if (gameObject.transform.position.y <= 3 && gameObject.GetComponent<Rigidbody2D>().velocity.magnitude > 0)
        {
            CheckCollision checkCollisionComponent = gameObject.GetComponent<CheckCollision>();
            if (checkCollisionComponent == null)
            {
                return;
            }
            else
            {
                checkCollisionComponent.enabled = true;
            }
        }
    }
}
