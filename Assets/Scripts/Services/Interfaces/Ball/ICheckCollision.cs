using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICheckCollision
{
    public void CheckColl(GameObject gameObject, Collision2D other);
    public void ChangeSize(GameObject gameObject);
}
