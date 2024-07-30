using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    private IRotation _rotation;
    private ISpawnBall _spawnBall;
    [SerializeField] private Transform _transform;
    [SerializeField] private float speedRotate;
    [SerializeField] private GameObject ball;
    
    void Start()
    {
        _rotation = Container.Resolve<IRotation>();
        _spawnBall = Container.Resolve<ISpawnBall>();
    }

    // Update is called once per frame
    void Update()
    {
        _rotation.RotationCannon(transform, speedRotate);
        _spawnBall.SpawnBalls(ball, _transform);
    }
}
