using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICheckGameOver
{
    public void SetTime(Collider2D other, bool isInside, float timeSpent);
    public void Check(Collider2D other, GameObject gameObject);
    
}
