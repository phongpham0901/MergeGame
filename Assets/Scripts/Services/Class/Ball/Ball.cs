using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private IMove _move;
    private ICheckMovement _checkMovement;
    private IShapeBall _shapeBall;
    [SerializeField] private float speed;
    [SerializeField] public int id;

    
    private void Awake()
    {
        _move = Container.Resolve<IMove>();
        _checkMovement = Container.Resolve<ICheckMovement>();
        _shapeBall = Container.Resolve<IShapeBall>();
    }

    void Start()
    {
        id = _shapeBall.GetIdBall(gameObject);
        Debug.Log(id);
        _move.Movement(gameObject, speed);
    }

    // Update is called once per frame
    void Update()
    {
        _shapeBall.SetShapeBall(gameObject, id);
    }

    private void FixedUpdate()
    {
        _checkMovement.CheckMove(gameObject);
    }
}
