using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICheckExit
{
    public void Check(GameObject gameObject, Collider2D collider2D);
    public IEnumerator ActiveLaser(GameObject gameObject);
}
