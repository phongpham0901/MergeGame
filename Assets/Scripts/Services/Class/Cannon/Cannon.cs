using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    private IRotation _rotation;
    private ISpawnBall _spawnBall;
    private IShapeCircle _shapeCircle;
    [SerializeField] private Transform _transform;
    [SerializeField] private float speedRotate;
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject circle;

    private void Awake()
    {
        _rotation = Container.Resolve<IRotation>();
        _spawnBall = Container.Resolve<ISpawnBall>();
        _shapeCircle = Container.Resolve<IShapeCircle>();
        
    }

    void Start()
    {
        _shapeCircle.SetShapeStart(circle);
    }

    // Update is called once per frame
    void Update()
    {
        _rotation.RotationCannon(transform, speedRotate);
        _spawnBall.SpawnBalls(ball, _transform, circle);
        _shapeCircle.SetShape(circle);
    }
}