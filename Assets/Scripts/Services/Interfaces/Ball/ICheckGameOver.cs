using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICheckGameOver
{
    public void Check(GameObject gameObject, Collider2D other);
    
}
