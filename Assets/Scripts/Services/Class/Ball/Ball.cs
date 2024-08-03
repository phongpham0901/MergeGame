using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private IMove _move;
    private ICheckMovement _checkMovement;
    private IShapeBall _shapeBall;
    private ICheckGameOver _checkGameOver;
    [SerializeField] private float speed;
    [SerializeField] public int id;
    [SerializeField] public bool isOver;
    private float timeSpent = 0f;
    private bool isInside = false;
    public float triggerDuration = 5f; // Thời gian cần thiết để kích hoạt hành động

    private void Awake()
    {
        _move = Container.Resolve<IMove>();
        _checkMovement = Container.Resolve<ICheckMovement>();
        _shapeBall = Container.Resolve<IShapeBall>();
        _checkGameOver = Container.Resolve<ICheckGameOver>();
    }

    void Start()
    {
        id = _shapeBall.GetIdBall(gameObject);
        Debug.Log(id);
        _move.Movement(gameObject, speed);
    }

    void Update()
    {
        _shapeBall.SetShapeBall(gameObject, id);
    }

    void FixedUpdate()
    {
        _checkMovement.CheckMove(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Finish"))
        {
            isInside = true;
            timeSpent = 0f; // Reset thời gian khi đối tượng vào vùng trigger
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Finish"))
        {
            isInside = false;
            timeSpent = 0f; // Reset thời gian khi đối tượng rời khỏi vùng trigger
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Finish"))
        {
            if (isInside)
            {
                timeSpent += Time.deltaTime; // Tăng thời gian đối tượng ở trong vùng trigger

                if (timeSpent >= triggerDuration)
                {
                    // Thực hiện hành động khi đối tượng ở trong vùng trigger quá lâu
                    Debug.Log("Đối tượng đã ở trong vùng trigger quá 5 giây!");
                    Time.timeScale = 0f;
                }
            }
        }
    }
}
