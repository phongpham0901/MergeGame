using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public string GetTag()
    {
        return gameObject.tag;
    }

    private void Update()
    {
        Debug.Log(GetTag());
    }
}
