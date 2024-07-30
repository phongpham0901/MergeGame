using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : IRotation
{
    public void RotationCannon(Transform transform, float speedRotate)
    {
        transform.eulerAngles = new Vector3(0,0,Mathf.PingPong(Time.time * speedRotate, 90) - 45);
    }
}
