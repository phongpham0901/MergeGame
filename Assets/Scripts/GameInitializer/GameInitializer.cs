using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    private void Awake()
    {
        //Cannon
        Container.Register<IRotation, Rotation>();
        Container.Register<ISpawnBall, SpawnBall>();
        Container.Register<IShapeCircle, ShapeCircle>();
        
        //Ball
        Container.Register<IMove, Move>();
        Container.Register<ICheckMovement, CheckMovement>();
        Container.Register<IShapeBall, ShapeBall>();
        Container.Register<ICheckCollision, CheckCol>();
    }
}
