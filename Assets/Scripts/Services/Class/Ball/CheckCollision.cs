using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    private GameManager gameManager;
    private ICheckCollision _checkCollision;

    private void Awake()
    {
        _checkCollision = Container.Resolve<ICheckCollision>();
    }

    private void Start()
    {
        if(gameManager == null) {return;}
        gameManager = FindObjectOfType<GameManager>();
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        _checkCollision.CheckColl(gameObject, other);
        /*
        ObjectPlayer otherObjectPlayer = other.gameObject.GetComponent<ObjectPlayer>();
        if (otherObjectPlayer == null) { return; }

        if (otherObjectPlayer.id == GetComponent<ObjectPlayer>().id)
        {
            if (otherObjectPlayer.id < 3)
            {
                //gameManager.Increa(otherObjectPlayer.id);
                SpawnGame();
                Destroy(other.gameObject);
            }
        }
        */
    }

    /*
    public void SpawnGame()
    {
        GetComponent<ObjectPlayer>().id += 1;
        Debug.Log("Spawn");
    }
    */
}
