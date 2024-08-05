using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private IMove _move;
    private IShapeBall _shapeBall;
    private ICheckGameOver _checkGameOver;
    [SerializeField] private float speed;
    [SerializeField] public int id;
    [SerializeField] public bool isOver;
    public float timeSpent = 0f;
    public bool isInside = true;
    public float triggerDuration = 4f; 

    private void Awake()
    {
        _move = Container.Resolve<IMove>();
        _shapeBall = Container.Resolve<IShapeBall>();
        _checkGameOver = Container.Resolve<ICheckGameOver>();
    }

    void Start()
    {
        id = _shapeBall.GetIdBall(gameObject);
        Debug.Log(id);
        _move.Movement(gameObject, speed);
    }

    void Update()
    {
        _shapeBall.SetShapeBall(gameObject, id);
        GetComponent<CheckCollision>().enabled = true;
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        _checkGameOver.SetTime(other, isInside, timeSpent);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        _checkGameOver.Check(other, gameObject);
    }
}
