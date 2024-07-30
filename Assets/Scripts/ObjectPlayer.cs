using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectPlayer : MonoBehaviour
{
    public int id;
    private Vector3 previousPosition;

    private void Awake()
    {
        // Initialize the 'id' using a method appropriate for Unity's lifecycle
        id = GetRandomNumber();
    }

    
    public int GetRandomNumber()
    {
        // Random.Range returns a float by default, so cast to int
        return UnityEngine.Random.Range(1, 3); // The upper limit is exclusive, so use 4 to include 3
    }
    
    private void Start()
    {
        // Initialize the previous position to the current position
        previousPosition = transform.position;
        GetComponent<Rigidbody2D>().velocity = -10 * transform.up;
    }

    private void Update()
    {
        
        if (id == 1)
        {
            GetComponent<SpriteRenderer>().color = Color.red;
            GetComponent<Transform>().localScale = new Vector3(0.5f,0.5f,1);
        }
        else if(id == 2)
        {
            GetComponent<SpriteRenderer>().color = Color.blue;
            GetComponent<Transform>().localScale = new Vector3(0.75f,0.75f,1);
        }
        else if(id == 3)
        {
            GetComponent<SpriteRenderer>().color = Color.green;
            GetComponent<Transform>().localScale = new Vector3(1,1,1);
        }
        
    }

    private void FixedUpdate()
    {
        
        
        if (transform.position != previousPosition)
        {
            Debug.Log("The object is moving.");
        }
        else
        {
            Debug.Log("The object is not moving.");
        }
        
        if (transform.position.y <= 3 && GetComponent<Rigidbody2D>().velocity.magnitude <= 0)
        {
            CheckCollision checkCollisionComponent = GetComponent<CheckCollision>();
            if (checkCollisionComponent == null)
            {
                return;
            }
            else
            {
                checkCollisionComponent.enabled = false;
            }
        }
        
        if (transform.position.y <= 3 && GetComponent<Rigidbody2D>().velocity.magnitude > 0)
        {
            CheckCollision checkCollisionComponent = GetComponent<CheckCollision>();
            if (checkCollisionComponent == null)
            {
                return;
            }
            else
            {
                checkCollisionComponent.enabled = true;
            }
        }
        previousPosition = transform.position;
    }
}