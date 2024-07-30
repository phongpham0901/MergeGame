using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    private void Awake()
    {
        Container.Register<IRotation, Rotation>();
        Container.Register<ISpawnBall, SpawnBall>();
    }
}
