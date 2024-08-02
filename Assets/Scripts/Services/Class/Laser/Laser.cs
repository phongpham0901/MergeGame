using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private ICheckExit _checkExit;
    [SerializeField] private GameObject laser;
    void Start()
    {
        _checkExit = Container.Resolve<ICheckExit>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(_checkExit.ActiveLaser(laser));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        _checkExit.Check(laser, other);
    }
}
