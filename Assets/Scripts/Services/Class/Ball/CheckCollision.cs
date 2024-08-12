using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    private GameManager gameManager;
    private AudioManager audioManager;
    private ICheckCollision _checkCollision;
    

    private void Awake()
    {
        _checkCollision = Container.Resolve<ICheckCollision>();
        gameManager = FindObjectOfType<GameManager>();
        audioManager = FindObjectOfType<AudioManager>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(gameManager == null) {return;}
        if (_checkCollision.GetCheckColl(gameObject, other))
        {
            Debug.Log("Increament");
            audioManager.PlaySFX1();
            gameManager.Increament(gameObject.GetComponent<Ball>().id*25);
        }
        _checkCollision.CheckColl(gameObject, other);
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if(gameManager == null) {return;}
        if (_checkCollision.GetCheckColl(gameObject, other))
        {
            Debug.Log("Stay Increa");
            audioManager.PlaySFX1();
            gameManager.Increament(gameObject.GetComponent<Ball>().id*25);
        }
        _checkCollision.CheckColl(gameObject, other);
    }
}
